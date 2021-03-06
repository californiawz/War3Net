﻿// ------------------------------------------------------------------------------
// <copyright file="BracketedExpressionTranspiler.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

#pragma warning disable SA1402 // File may only contain a single type
#pragma warning disable SA1649 // File name should match first type name

using System;
using System.Text;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace War3Net.CodeAnalysis.Jass.Transpilers
{
    public static partial class JassToCSharpTranspiler
    {
        public static BracketedArgumentListSyntax Transpile(this Syntax.BracketedExpressionSyntax bracketedExpressionNode)
        {
            _ = bracketedExpressionNode ?? throw new ArgumentNullException(nameof(bracketedExpressionNode));

            return SyntaxFactory.BracketedArgumentList(
                SyntaxFactory.SingletonSeparatedList(
                    SyntaxFactory.Argument(
                        bracketedExpressionNode.ExpressionNode.Transpile())));
        }
    }

    public static partial class JassToLuaTranspiler
    {
        public static void Transpile(this Syntax.BracketedExpressionSyntax bracketedExpressionNode, ref StringBuilder sb)
        {
            _ = bracketedExpressionNode ?? throw new ArgumentNullException(nameof(bracketedExpressionNode));

            sb.Append('[');
            bracketedExpressionNode.ExpressionNode.Transpile(ref sb);
            sb.Append(']');
        }
    }
}