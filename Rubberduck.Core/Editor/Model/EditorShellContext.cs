﻿using Rubberduck.UI.Abstract;

namespace Rubberduck.Core.Editor
{
    public class EditorShellContext : IEditorShellContext
    {
        public EditorShellContext(IEditorShellViewModel shell)
        {
            Shell = shell;
        }

        public static EditorShellContext Current { get; set; }
        public IEditorShellViewModel Shell { get; }
    }
}