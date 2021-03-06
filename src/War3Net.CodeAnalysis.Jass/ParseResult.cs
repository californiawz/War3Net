﻿// ------------------------------------------------------------------------------
// <copyright file="ParseResult.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

namespace War3Net.CodeAnalysis.Jass
{
    internal class ParseResult
    {
        private readonly SyntaxNode _node;
        private readonly int _consumedTokens;

        public ParseResult(SyntaxNode node, int consumedTokens)
        {
            _node = node;
            _consumedTokens = consumedTokens;
        }

        public SyntaxNode Node => _node;

        public int ConsumedTokens => _consumedTokens;
    }
}