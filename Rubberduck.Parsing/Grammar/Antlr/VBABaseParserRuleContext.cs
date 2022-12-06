using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Rubberduck.Parsing.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Rubberduck.Parsing.Grammar
{
    public abstract class VBABaseParserRuleContext : ParserRuleContext
    {
        public VBABaseParserRuleContext() : base() 
        {
            Offset = new DocumentOffset(Start?.StartIndex ?? 0, Stop?.StopIndex ?? 0);
        }
        
        public VBABaseParserRuleContext(ParserRuleContext parent, int invokingStateNumber) : base(parent, invokingStateNumber) { }

        public DocumentOffset Offset { get; }
    }
}
