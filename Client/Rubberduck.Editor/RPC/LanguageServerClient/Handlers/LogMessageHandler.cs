﻿using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using OmniSharp.Extensions.LanguageServer.Protocol.Window;
using System.Threading.Tasks;
using MediatR;
using System.Threading;
using Rubberduck.ServerPlatform;
using System;
using System.Collections.Generic;
using Rubberduck.UI.Services;
using Rubberduck.UI.Shell.Tools.ServerTrace;
using System.Text.Json;
using Rubberduck.InternalApi.ServerPlatform;

namespace Rubberduck.Editor.RPC.LanguageServerClient.Handlers
{
    public class LogMessageHandler : LogMessageHandlerBase
    {
        private readonly UIServiceHelper _service;
        private readonly ILanguageServerTraceViewModel _traceToolwindow;

        public LogMessageHandler(UIServiceHelper service, ILanguageServerTraceViewModel traceToolWindow)
        {
            _service = service;
            _traceToolwindow = traceToolWindow;
        }

        private static readonly IDictionary<MessageType, Action<ServerPlatformServiceHelper, string>> MessageTypeMap = 
            new Dictionary<MessageType, Action<ServerPlatformServiceHelper, string>>
            {
                [MessageType.Error] = (service, message) => service.LogError(message),
                [MessageType.Warning] = (service, message) => service.LogWarning(message),
                [MessageType.Info] = (service, message) => service.LogInformation(message),
                [MessageType.Log] = (service, message) => service.LogTrace(message),
            };

        public override async Task<Unit> Handle(LogMessageParams request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var type = request.Type;

            var service = _service;
            service.LogTrace("Received LogTrace request.");

            cancellationToken.ThrowIfCancellationRequested();

            var payload = JsonSerializer.Deserialize<LogMessagePayload>(request.Message);
            _traceToolwindow.OnServerMessage(payload);

            return await Task.FromResult(Unit.Value);
        }
    }
}
