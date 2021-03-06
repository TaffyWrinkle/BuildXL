// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;

namespace BuildXL.Cache.ContentStore.Interfaces.FileSystem
{
    /// <summary>
    ///     Information about a file.
    /// </summary>
    [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes")]
    public struct FileInfo
    {
        /// <summary>
        ///     Full path to the file.
        /// </summary>
        public AbsolutePath FullPath;

        /// <summary>
        ///     Size of the file in bytes.
        /// </summary>
        public long Length;
    }
}
