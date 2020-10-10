using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingTest
{
    public partial class FormPingTest : Form
    {
        public FormPingTest()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            cbProtocol.SelectedIndex = 0;


        }

        private int _send = 0;
        private int _received = 0;
        private int _loss = 0;
        private decimal _speed = 0;
        private long _totalSpeed = 0;
        private decimal _lossRate = 0;
        private List<Record> _dataList = new List<Record>();

        private void Init()
        {
            _send = 0;
            _received = 0;
            _loss = 0;
            _speed = 0;
            _totalSpeed = 0;
            _lossRate = 0;
            lvData.Items.Clear();
            _dataList.Clear();
        }



        private void UpdateBandwidthLog(string message)
        {
           // rtLog.AppendText(DateTime.Now.ToShortTimeString() + "--");
            rtLog.AppendText(message);
           // rtLog.AppendText(Environment.NewLine);
            rtLog.SelectionStart = rtLog.Text.Length;
            rtLog.ScrollToCaret();
        }

        

        private void InitBandwidth()
        {

          //  rtLog.Text = string.Empty;
            _fileMonitor.ClearLog();
            _ctsBandwidth = new CancellationTokenSource();
            btnStartBandwidth.Enabled = false;
            btnStopBandwidth.Enabled = true;

        }


        private void InsertRecord()
        {
            lvData.Items.Insert(0, new ListViewItem());
        }

        private void UpdateStatus(Record item)
        {
            ListViewItem lv = new ListViewItem();
            lv.Text = item.Time;
            lv.SubItems.Add(item.Speed.ToString());
            lv.SubItems.Add(item.TTL);
            lv.SubItems.Add(item.Error);
            lv.SubItems.Add(item.Status);
            if (item.Status == "Failed")
                lv.BackColor = Color.Red;
            if (lvData.Items.Count > 500)
            {
                for (int i = 0; i < 200; i++)
                    lvData.Items.RemoveAt(0);
            }

            lvData.Items.Insert(0, lv);
            //   lvData.Items.Add(lv);

            lbSend.Text = _send.ToString();
            lbReceived.Text = _received.ToString();
            lbLost.Text = _loss.ToString();
            lbLostRate.Text = _lossRate.ToString("F2") + "%";
            lbSpeed.Text = _speed.ToString("F2") + "ms";
        }

        public void InvokeIfNeeded(Action<Record> action, Record record)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(action, record);
            }
            else
            {
                action.Invoke(record);
            }
        }


        private void EndBandwidthTest()
        {
            btnStartBandwidth.Enabled = true;
            btnStopBandwidth.Enabled = false;
        }


        private CancellationTokenSource _cts;
        private CancellationTokenSource _ctsBandwidth;

        private void HandleData(string content)
        {
            if (!IsOtherMessage(content))
            {
                if (content.Contains("Reply"))
                {
                    string useContent = content.Substring(content.IndexOf(":") + 1);
                    string strSpeed = Utility.GetStringArrayValue(useContent, 1, ' ');
                    int speed = Utility.TryParseInt(Utility.RemoveNotNumber(strSpeed));
                    string strTTL = Utility.GetStringArrayValue(useContent, 2, ' ');
                    string ttl = Utility.RemoveNotNumber(strTTL);

                    _received++;
                    _send++;
                    _totalSpeed = _totalSpeed + speed;
                    _speed = (decimal)_totalSpeed / _received;
                    _lossRate = (decimal)_loss * 100 / _send;

                    Record record = new Record
                    {
                        Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"),
                        TTL = ttl,
                        Status = "Success",
                        Speed = speed,
                    };
                    if (_dataList.Count > 100000)
                        _dataList.RemoveRange(0, 10000);
                    _dataList.Add(record);
                    Log.Info($"{record.Speed} {record.TTL} {record.Error} {record.Status}");
                    InvokeIfNeeded(UpdateStatus, record);
                }
                else //failed
                {
                    _send++;
                    _loss++;
                    _lossRate = (decimal)_loss * 100 / _send;

                    Record record = new Record
                    {
                        Time = DateTime.Now.ToString(),
                        TTL = string.Empty,
                        Status = "Failed",
                        Speed = 0,
                        Error = content
                    };
                    if (_dataList.Count > 100000)
                        _dataList.RemoveRange(0, 10000);
                    _dataList.Add(record);
                    Log.Info($"{record.Time} {record.Speed} {record.TTL} {record.Error} {record.Status}");
                    InvokeIfNeeded(UpdateStatus, record);
                }

            }
        }

        private bool IsOtherMessage(string content)
        {
            if (content.Contains("Ping")
              || content.Contains("Packets")
              || content.Contains("Approximate")
              || content.Contains("Minimum")
              || content.Contains("Microsoft")
              || content.Contains("Active")
              || content.Contains("ping")
              || content.Contains("chcp")
              || string.IsNullOrEmpty(content)
             )
                return true;
            else
                return false;
        }


        public void ExecuteIperfTest(object parameter)
        {
            string command = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"iperf\iperf-3.1.3-win64\iperf3.exe");
            if (Utility.GetOSBit() == 32)
                command = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"iperf\iperf-3.1.3-win32\iperf3.exe");

            BandwidthCommandParameter cmd = parameter as BandwidthCommandParameter;

            StringBuilder sb = new StringBuilder();

            if (cmd.IsServer)
            {
                sb.Append($"-s ");
                if(!string.IsNullOrEmpty(cmd.Port))
                    sb.Append($"-p {cmd.Port} ");
            }

            else
            {
                sb.Append($"-c {cmd.Target} ");

                if (!string.IsNullOrEmpty(cmd.Port))
                    sb.Append($"-p {cmd.Port} ");

                if (!string.IsNullOrEmpty(cmd.Size))
                    sb.Append($"-n {cmd.Size} ");
                else if (!string.IsNullOrEmpty(cmd.Time))
                    sb.Append($"-t {cmd.Time} ");

                if(!cmd.IsTcp)
                    sb.Append($"-u ");

                if (!string.IsNullOrEmpty(cmd.Windows))
                    sb.Append($"-W {cmd.Windows} ");


                if (!string.IsNullOrEmpty(cmd.MTU))
                    sb.Append($"-M {cmd.MTU} ");

                if (!string.IsNullOrEmpty(cmd.Buffer))
                    sb.Append($"-l {cmd.Buffer} ");

                if (!string.IsNullOrEmpty(cmd.Bandwidth))
                    sb.Append($"-b {cmd.Bandwidth} ");

                if (!string.IsNullOrEmpty(cmd.parallel))
                    sb.Append($"-P {cmd.parallel} ");

                if(cmd.IsReversal)
                     sb.Append($"-R ");


            }

            sb.Append($"--logfile {_bandwidthLog}");


            var psi = new ProcessStartInfo(command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                Arguments = sb.ToString()
            };
            var proc = Process.Start(psi);
            if (proc == null)
            {
                Log.Debug("can not start process");
            }
            else
            {
                using (var sr = proc.StandardOutput)
                {
                    while (!_ctsBandwidth.IsCancellationRequested && !proc.HasExited)
                    {

                        Thread.Sleep(1000);

                    }

                    if (!proc.HasExited)
                    {
                        proc.Kill();
                    }
                    this.Invoke(new Action(EndBandwidthTest));
                }
            }
        }



        public void ExecuteCommandAndGetOutput(object parameter)
        {
            string command = "ping";
            CommandLineParameter cmd = parameter as CommandLineParameter;
            string arguments = string.Empty;
            if (string.IsNullOrEmpty(cmd.Size))
                arguments = $" {cmd.Target} -t";
            else
                arguments = $" {cmd.Target} -t -l {cmd.Size}";


            var psi = new ProcessStartInfo("cmd.exe")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            };
            var proc = Process.Start(psi);
            proc.StandardInput.AutoFlush = true;
            if (proc == null)
            {
                Log.Debug("can not start process");
            }
            else
            {
                proc.StandardInput.WriteLine("chcp 437");
                proc.StandardInput.WriteLine($"{command} {arguments}");

                using (var sr = proc.StandardOutput)
                {
                    while (!_cts.IsCancellationRequested && !sr.EndOfStream)
                    {
                        HandleData(sr.ReadLine());
                    }

                    if (!proc.HasExited)
                    {
                        proc.Kill();
                    }
                    InvokeIfNeeded(End, null);
                }
            }
        }

        

        public void End(Record data)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            Log.Info("Stop ping, ping result as:");
            Log.Info($"[Send:{lbSend.Text}],[Received:{lbReceived.Text}],[Loss:{lbLost.Text}],[LossRate:{lbLostRate.Text}],[Speed:{lbSpeed.Text}]");
        }

        public class CommandLineParameter
        {
            public string Target { get; set; }
            public string Size { get; set; }
        }

        public class ScanPortParameter
        {
            public string Ip { get; set; }
            public string Port { get; set; }
            public bool isTcp { get; set; }
        }


        public class BandwidthCommandParameter
        {
            public string Target { get; set; }
            public string Port { get; set; }
            public string Time { get; set; }
            public bool IsTcp { get; set; }
            public bool IsServer { get; set; }
            public bool IsReversal { get; set; }
            public string Size { get; set; }
            public string Windows { get; set; }
            public string MTU { get; set; }
            public string Buffer { get; set; }
            public string Bandwidth { get; set; }
            public string parallel { get; set; }

        }


        public class Record
        {
            public string Time { get; set; }
            public string TTL { get; set; }
            public string Status { get; set; }
            public int Speed { get; set; }
            public string Error { get; set; }
        }

    

        private void btnStart_Click(object sender, EventArgs e)
        {
            int size = Utility.TryParseInt(txtSize.Text);
            if (size < 1 && size > 65500)
            {
                MessageBox.Show("Size between 1 to 65500");
                return;
            }

            if (string.IsNullOrEmpty(txtTarget.Text))
            {
                MessageBox.Show("input the host first");
                return;
            }

            Init();

            _cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(ExecuteCommandAndGetOutput, new CommandLineParameter
            {
                Target = txtTarget.Text,
                Size = txtSize.Text
            });

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void pnStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvData_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (_dataList.Count < 1)
                return;

            if (e.Column != 1 && e.Column != 4)
                return;

            if (e.Column == 1)
            {
                _dataList.Sort((x, y) =>
                  {
                      if (x.Speed < y.Speed)
                          return 1;
                      else if (x.Speed == y.Speed)
                          return 0;
                      else
                          return -1;
                  });
            }

            if (e.Column == 4)
            {
                _dataList.Sort((x, y) =>
                {
                    if (x.Speed > y.Speed)
                        return 1;
                    else if (x.Speed == y.Speed)
                        return 0;
                    else
                        return -1;
                });
            }

            lvData.Items.Clear();
            //refill list
            lvData.BeginUpdate();
            foreach (Record item in _dataList)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = item.Time;
                lv.SubItems.Add(item.Speed.ToString());
                lv.SubItems.Add(item.TTL);
                lv.SubItems.Add(item.Error);
                lv.SubItems.Add(item.Status);
                if (item.Status == "Failed")
                    lv.BackColor = Color.Red;
                lvData.Items.Add(lv);
            }
            lvData.EndUpdate();

        }

        public bool ValidateScanInput()
        {
            if (!string.IsNullOrEmpty(txtScanPort.Text))
            {
                int port = Utility.TryParseInt(txtPort.Text);
                if (port < 1 || port > 65500)
                {
                    MessageBox.Show("port between 1 to 65500");
                    return false;
                }
            }

            if (!Utility.IsIP(txtScanIp.Text))
            {
                MessageBox.Show("target format is incorrected");
                return false;
            }

            return true;
        }

        public bool ValidateInput()
        {
            if(!string.IsNullOrEmpty(txtPort.Text))
            {
                int port = Utility.TryParseInt(txtPort.Text);
                if (port < 1 || port > 65500)
                {
                    MessageBox.Show("port between 1 to 65500");
                    return false;
                }
            }

            if(!cbServer.Checked)
            {
                if (!Utility.IsIP(txtIp.Text))
                {
                    MessageBox.Show("target format is incorrected");
                    return false;
                }

                if(string.IsNullOrEmpty(txtSendSize.Text))
                {
                    int time = Utility.TryParseInt(txtTime.Text);
                    if (time < 10 || time > 3600)
                    {
                        MessageBox.Show("time between 10 to 3600");
                        return false;
                    }
                }
            }



            return true;
        }



        private void btnStartBandwidth_Click(object sender, EventArgs e)
        {

            if (!ValidateInput())
                return;

            InitBandwidth();

            UpdateBandwidthLog("begin to test\r\n");

            ThreadPool.QueueUserWorkItem(ExecuteIperfTest, new BandwidthCommandParameter
            {
                Target = txtIp.Text,
                Port = txtPort.Text,
                Time = txtTime.Text,
                IsTcp = cbProtocol.Text.Equals("TCP")?true:false,
                IsServer = cbServer.Checked ? true : false,
                Size = txtSendSize.Text,
                Windows = txtWindow.Text,
                MTU = txtMTU.Text,
                Buffer = txtBuffer.Text,
                Bandwidth = txtBandwidth.Text,
                parallel = txtParallel.Text,
                IsReversal = cbReversal.Checked?true:false
            });


        }

        private void btnStopBandwidth_Click(object sender, EventArgs e)
        {
            _ctsBandwidth.Cancel();
            btnStartBandwidth.Enabled = true;
            btnStopBandwidth.Enabled = false;
        }

        TimedFileMonitor _fileMonitor = null;

        private string _bandwidthLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"iperf\\log.txt");

        private void OpenFile()
        {
            if (!File.Exists(_bandwidthLog))
                File.Create(_bandwidthLog);
            _fileMonitor = new TimedFileMonitor(_bandwidthLog, null);
            _fileMonitor.FileUpdated += new Action<IFileMonitor, string>(_fileMonitor_FileUpdated);
            _fileMonitor.OpenFile();
            _fileMonitor.ClearLog();
        }

        private void _fileMonitor_FileUpdated(IFileMonitor fm, string content)
        {

            this.Invoke(new Action<string>(UpdateBandwidthLog), content);
            Log.Info(content);

        }

        private void FormPingTest_Load(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void FormPingTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_fileMonitor != null)
                _fileMonitor.Dispose();
        }

        private void UpdateScanLog(string message)
        {
            // rtLog.AppendText(DateTime.Now.ToShortTimeString() + "--");

            if(rtLog.InvokeRequired)
            {
                this.Invoke(new Action<string>(WriteScanLog), message);
            }
            else
            {
                WriteScanLog(message);
            }

        }
        private void WriteScanLog(string message)
        {
            rtScanLog.AppendText(message);
            rtScanLog.AppendText(Environment.NewLine);
            rtScanLog.SelectionStart = rtLog.Text.Length;
            rtScanLog.ScrollToCaret();
        }

        public void NmapScan(object parameter)
        {
            string command = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"nmap\nmap.exe");

            ScanPortParameter cmd = parameter as ScanPortParameter;

            StringBuilder sb = new StringBuilder();

            if(cmd.isTcp)
            {
                sb.Append($"-sT {cmd.Ip} -p {cmd.Port}");
            }
            else
            {
                sb.Append($"-sU {cmd.Ip} -p {cmd.Port}");
            }

            var psi = new ProcessStartInfo(command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                Arguments = sb.ToString()
            };
            var proc = Process.Start(psi);
            if (proc == null)
            {
                Log.Debug("can not start process");
            }
            else
            {
                using (var sr = proc.StandardOutput)
                {
                    while (!sr.EndOfStream)
                    {
                        UpdateScanLog(sr.ReadLine());
                    }

                    if (!proc.HasExited)
                    {
                        proc.Kill();
                    }
                }
            }
        }



        private void ScanPort(bool isTcp)
        {
            if (!ValidateScanInput())
                return;

            rtScanLog.Clear();

            ThreadPool.QueueUserWorkItem(NmapScan, new ScanPortParameter
            {
                Ip = txtScanIp.Text,
                Port = txtScanPort.Text,
                isTcp = isTcp
            });
        }

        private void btnScanTcp_Click(object sender, EventArgs e)
        {
            ScanPort(true);
        }

        private void btnScanUdp_Click(object sender, EventArgs e)
        {
            ScanPort(false);
        }

        private void btnRemark_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("【Open】-The port is open, data arrives at the host, and a program monitors the port;");
            sb.AppendLine("【Closed】-The port is closed, the data arrives at the host, and there is no program to monitor on the port;");
            sb.AppendLine("【Filtered】-The data does not reach the host, the returned result is empty, and the data is filtered by the firewall or IDS;");
            sb.AppendLine("【UnFiltered】-Data has arrived at the host, but the current state of the port cannot be identified;");
            sb.AppendLine("【Open|Filtered】-The port has no return value, which mainly occurs in UDP, IP, FIN, NULL and Xmas scans;");
            sb.AppendLine("【Closed|Filtered】-Only occurs during IP ID idle scanning;");
            MessageBox.Show(sb.ToString(), "PingTest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
