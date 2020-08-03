﻿// ccset.cs
//
// Copyright 2010 Microsoft Corporation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using NUglify.JavaScript.Visitors;

namespace NUglify.JavaScript.Syntax
{
    public class ConditionalCompilationSet : ConditionalCompilationStatement
    {
        private AstNode m_value;

        public AstNode Value
        {
            get { return m_value; }
            set
            {
                ReplaceNode(ref m_value, value);
            }
        }

        public string VariableName { get; set; }

        public ConditionalCompilationSet(SourceContext context)
            : base(context)
        {
        }

        public override IEnumerable<AstNode> Children
        {
            get
            {
                return EnumerateNonNullNodes(Value);
            }
        }

        public override void Accept(IVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override bool ReplaceChild(AstNode oldNode, AstNode newNode)
        {
            if (Value == oldNode)
            {
                Value = newNode;
                return true;
            }
            return false;
        }
    }
}