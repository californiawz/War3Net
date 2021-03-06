﻿// ------------------------------------------------------------------------------
// <copyright file="RibbonEmitter.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using System.Numerics;

using War3Net.Modeling.Enums;

namespace War3Net.Modeling.DataStructures
{
    public struct RibbonEmitter : INode
    {
        public RibbonEmitter(string name)
            : this()
        {
            Name = name;
        }

        public float HeightAbove { get; set; }

        public float HeightBelow { get; set; }

        public float Alpha { get; set; }

        public Vector3 Color { get; set; }

        public float Lifespan { get; set; }

        public uint TextureSlot { get; set; }

        public uint EmissionRate { get; set; }

        public uint Rows { get; set; }

        public uint Columns { get; set; }

        public uint MaterialId { get; set; }

        public float Gravity { get; set; }

        public AnimationChannel<float>? Visibilities { get; set; }

        public AnimationChannel<float>? HeightsAbove { get; set; }

        public AnimationChannel<float>? HeightsBelow { get; set; }

        public AnimationChannel<float>? Alphas { get; set; }

        public AnimationChannel<Vector3>? Colors { get; set; }

        public AnimationChannel<uint>? TextureSlots { get; set; }

        /// <inheritdoc/>
        public string Name { get; set; }

        /// <inheritdoc/>
        public uint ObjectId { get; set; }

        /// <inheritdoc/>
        public uint? ParentId { get; set; }

        /// <inheritdoc/>
        public NodeFlags Flags { get; set; }

        /// <inheritdoc/>
        public AnimationChannel<Vector3>? Translations { get; set; }

        /// <inheritdoc/>
        public AnimationChannel<Quaternion>? Rotations { get; set; }

        /// <inheritdoc/>
        public AnimationChannel<Vector3>? Scalings { get; set; }
    }
}