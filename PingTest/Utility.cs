using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;

namespace PingTest
{
    public  class Utility
    {
        public static string RemoveNotNumber(string key)
        {
            return System.Text.RegularExpressions.Regex.Replace(key, @"[^\d]*", "").Trim();
        }

        public static string GetStringArrayValue(string str, int index, char seperator)
        {
            List<string> strList = str.Split(seperator).Where(q => !string.IsNullOrEmpty(q)).ToList();
            if (strList.Count <= index)
                return string.Empty;
            else
                return strList[index];
        }

        public static int GetStringCount(string str, char seperator)
        {
            List<string> strList = str.Split(seperator).Where(q => !string.IsNullOrEmpty(q)).ToList();
            return strList.Count();
        }

        public static int TryParseInt(string str)
        {
            int result = 0;
            int.TryParse(str, out result);
            return result;
        }

        public static bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        public static int GetOSBit()
        {

            try
            {
                string addressWidth = String.Empty;
                ConnectionOptions mConnOption = new ConnectionOptions();
                ManagementScope mMs = new ManagementScope(@"\\localhost", mConnOption);
                ObjectQuery mQuery = new ObjectQuery("select AddressWidth from Win32_Processor");
                ManagementObjectSearcher mSearcher = new ManagementObjectSearcher(mMs, mQuery);
                ManagementObjectCollection mObjectCollection = mSearcher.Get();
                foreach (ManagementObject mObject in mObjectCollection)
                {
                    addressWidth = mObject["AddressWidth"].ToString();
                }
                return Int32.Parse(addressWidth);
            }
            catch (Exception ex)
            {
                return 32;
            }

        }

    }
}
