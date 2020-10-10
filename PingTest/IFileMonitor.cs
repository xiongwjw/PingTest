﻿using System;
using System.Text;
using System.Threading.Tasks;

namespace PingTest
{
    /// <summary>
    /// Implemented by classes that monitor a file for changes and report them.
    /// </summary>
    public interface IFileMonitor : IDisposable
    {
        /// <summary>
        /// Occurs when the file being monitored is updated.
        /// </summary>
        event Action<IFileMonitor, string> FileUpdated;

        /// <summary>
        /// Occurs when the file being monitored is deleted.
        /// </summary>
      

        /// <summary>
        /// Gets the path of the file being monitored.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        string FilePath { get; }

        /// <summary>
        /// Gets or sets the length of the read buffer.
        /// </summary>
        /// <value>
        /// The length of the read buffer.
        /// </value>
        int ReadBufferSize { get; set; }

        /// <summary>
        /// Refreshes the <see cref="IFileMonitor"/> checking for any changes.
        /// </summary>
        /// <returns></returns>
        void RefreshAsync();

        /// <summary>
        /// Updates the encoding used to read the file.
        /// </summary>
        /// <param name="encoding">The encoding.</param>
        void UpdateEncoding(Encoding encoding);

        /// <summary>
        /// Gets or sets a value indicating whether a buffer is used read the changes in blocks.
        /// </summary>
        /// <value>
        ///   <c>true</c> if a buffer is used; otherwise, <c>false</c>.
        /// </value>
        bool BufferedRead { get; set; }
    }
}