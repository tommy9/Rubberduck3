﻿using System.Text.Json.Serialization;
namespace Rubberduck.InternalApi.RPC.LSP.Capabilities
{
    public class InlineValueClientCapabilities
    {
        /// <summary>
        /// Whether the client supports dynamic registration.
        /// </summary>
        [JsonPropertyName("dynamicRegistration")]
        public bool SupportsDynamicRegistration { get; set; }
    }
}