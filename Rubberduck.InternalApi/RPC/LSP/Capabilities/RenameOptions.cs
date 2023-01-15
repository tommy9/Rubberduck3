﻿using System.Text.Json.Serialization;

namespace Rubberduck.InternalApi.RPC.LSP.Capabilities
{
    public class RenameOptions : WorkDoneProgressOptions
    {
        /// <summary>
        /// If <c>true</c>, renames should be prepared and confirmed by the user before being executed.
        /// </summary>
        [JsonPropertyName("prepareProvider")]
        public bool IsPrepareProvider { get; set; }
    }
}