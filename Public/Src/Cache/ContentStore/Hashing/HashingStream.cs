// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.IO;

namespace BuildXL.Cache.ContentStore.Hashing
{
    /// <summary>
    ///     A stream that can provide a hash of its content.
    /// </summary>
    public abstract class HashingStream : Stream
    {
        /// <summary>
        ///     Get the calculated content hash for the stream's content.
        /// </summary>
        public abstract ContentHash GetContentHash();

        /// <summary>
        ///     Gets the amount of time that has been spent hashing.
        /// </summary>
        public abstract TimeSpan TimeSpentHashing { get; }
    }
}
