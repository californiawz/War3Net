﻿// ------------------------------------------------------------------------------
// <copyright file="ReturnStatementTranspiler.cs" company="Drake53">
// Copyright (c) 2019 Drake53. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// ------------------------------------------------------------------------------

#pragma warning disable SA1649 // File name should match first type name

using System;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace War3Net.CodeAnalysis.Jass.Transpilers
{
    public static partial class JassToCSharpTranspiler
    {
        public static StatementSyntax Transpile(this Syntax.ReturnStatementSyntax returnStatementNode)
        {
            _ = returnStatementNode ?? throw new ArgumentNullException(nameof(returnStatementNode));

            return SyntaxFactory.ReturnStatement(returnStatementNode.ExpressionNode?.Transpile());
        }
    }
}