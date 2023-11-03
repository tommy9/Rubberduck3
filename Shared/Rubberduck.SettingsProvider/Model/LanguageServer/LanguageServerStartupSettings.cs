﻿using Rubberduck.InternalApi.ServerPlatform;
using Rubberduck.SettingsProvider.Model.ServerStartup;
using System;

namespace Rubberduck.SettingsProvider.Model.LanguageServer
{
    /// <summary>
    /// Configures the command-line startup options of the language server.
    /// </summary>
    public record class LanguageServerStartupSettings : ServerStartupSettings
    {
        public static readonly RubberduckSetting[] DefaultSettings = GetDefaultSettings(ServerPlatformSettings.LanguageServerDefaultPipeName,
            @$"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Rubberduck\LanguageServer\{ServerPlatformSettings.LanguageServerExecutable}");

        public LanguageServerStartupSettings()
        {
            DefaultValue = DefaultSettings;
        }
    }
}