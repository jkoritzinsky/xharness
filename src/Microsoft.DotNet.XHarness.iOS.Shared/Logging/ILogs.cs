// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Microsoft.DotNet.XHarness.Common.Logging;

namespace Microsoft.DotNet.XHarness.iOS.Shared.Logging
{
    /// <summary>
    /// Represents a collection of logs located in some directory.
    /// User can grow this collection via this interface.
    /// </summary>
    public interface ILogs : IList<IFileBackedLog>, IDisposable
    {
        /// <summary>
        /// Path to the directory where this collection of logs is located
        /// </summary>
        string Directory { get; set; }

        /// <summary>
        /// Create a new log backed with a file 
        /// </summary>
        /// <param name="filename">Name of the file</param>
        /// <param name="description">Purpose / type</param>
        /// <param name="timestamp">True when the newly created log should add timestamps</param>
        /// <returns>IFileBackedLog handle to the log</returns>
        IFileBackedLog Create(string filename, string description, bool? timestamp = null);

        /// <summary>
        /// Adds an existing file to this collection of logs.
        /// If the file is not inside the log directory, then it's copied there.
        /// </summary>
        /// <param name="path">Full path to the file</param>
        /// <returns>IFileBackedLog handle to the log</returns>
        IFileBackedLog AddFile(string path);

        /// <summary>
        /// Adds an existing file to this collection of logs.
        /// If the file is not inside the log directory, then it's copied there.
        /// </summary>
        /// <param name="path">Full path to the file</param>
        /// <param name="description">Purpose / type</param>
        /// <returns>IFileBackedLog handle to the log</returns>
        IFileBackedLog AddFile(string path, string description);

        /// <summary>
        /// Create an empty file in the log directory and return the full path to the file
        /// </summary>
        /// <param name="path">Relative path where the file will be stored</param>
        /// <param name="description">Purpose / type</param>
        /// <returns>IFileBackedLog handle to the log</returns>
        string CreateFile(string path, string description);

        /// <summary>
        /// Create an empty file in the log directory and return the full path to the file
        /// </summary>
        /// <param name="path">Relative path where the file will be stored</param>
        /// <param name="description">Purpose / type</param>
        /// <returns>IFileBackedLog handle to the log</returns>
        string CreateFile(string path, LogType type);
    }
}
