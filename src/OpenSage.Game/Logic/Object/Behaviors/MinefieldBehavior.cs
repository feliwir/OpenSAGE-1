﻿using System.IO;
using OpenSage.Data.Ini;
using OpenSage.FileFormats;
using OpenSage.Mathematics;

namespace OpenSage.Logic.Object
{
    public sealed class MinefieldBehavior : UpdateModule
    {
        internal override void Load(BinaryReader reader)
        {
            var version = reader.ReadVersion();
            if (version != 1)
            {
                throw new InvalidDataException();
            }

            base.Load(reader);

            // TODO
        }
    }

    /// <summary>
    /// INI file comments indicate that this is not an accurate name; it's a really a 
    /// single mine behaviour.
    /// </summary>
    public sealed class MinefieldBehaviorModuleData : BehaviorModuleData
    {
        internal static MinefieldBehaviorModuleData Parse(IniParser parser) => parser.ParseBlock(FieldParseTable);

        private static readonly IniParseTable<MinefieldBehaviorModuleData> FieldParseTable = new IniParseTable<MinefieldBehaviorModuleData>
        {
            { "DetonationWeapon", (parser, x) => x.DetonationWeapon = parser.ParseAssetReference() },
            { "DetonatedBy", (parser, x) => x.DetonatedBy = parser.ParseEnumBitArray<ObjectFilterRelationship>() },
            { "ScootFromStartingPointTime", (parser, x) => x.ScootFromStartingPointTime = parser.ParseInteger() },
            { "RepeatDetonateMoveThresh", (parser, x) => x.RepeatDetonateMoveThresh = parser.ParseFloat() },
            { "NumVirtualMines", (parser, x) => x.NumVirtualMines = parser.ParseInteger() },
            { "Regenerates", (parser, x) => x.Regenerates = parser.ParseBoolean() },
            { "StopsRegenAfterCreatorDies", (parser, x) => x.StopsRegenAfterCreatorDies = parser.ParseBoolean() },
            { "DegenPercentPerSecondAfterCreatorDies", (parser, x) => x.DegenPercentPerSecondAfterCreatorDies = parser.ParsePercentage() },
        };

        public string DetonationWeapon { get; private set; }
        public BitArray<ObjectFilterRelationship> DetonatedBy { get; private set; }
        public int ScootFromStartingPointTime { get; private set; }
        public float RepeatDetonateMoveThresh { get; private set; }
        public int NumVirtualMines { get; private set; }
        public bool Regenerates { get; private set; }
        public bool StopsRegenAfterCreatorDies { get; private set; }
        public Percentage DegenPercentPerSecondAfterCreatorDies { get; private set; }

        internal override BehaviorModule CreateModule(GameObject gameObject, GameContext context)
        {
            return new MinefieldBehavior();
        }
    }

    public enum ObjectFilterRelationship
    {
        [IniEnum("ENEMIES")]
        Enemies,

        [IniEnum("NEUTRAL")]
        Neutral,
    }
}
