﻿using Rubberduck.UI.Abstract;

namespace Rubberduck.Core.Editor.Commands
{
    public interface IEditorShellCommand
    {
        IEditorShellViewModel Shell { get; set; }
    }
}
