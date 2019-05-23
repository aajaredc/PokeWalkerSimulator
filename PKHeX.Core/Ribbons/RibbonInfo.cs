﻿using System.Collections.Generic;

namespace PKHeX.Core
{
    public sealed class RibbonInfo
    {
        public readonly string Name;
        public bool HasRibbon { get; set; }
        public int RibbonCount { get; set; }

        private RibbonInfo(string name, bool hasRibbon)
        {
            Name = name;
            HasRibbon = hasRibbon;
            RibbonCount = -1;
        }

        private RibbonInfo(string name, int count)
        {
            Name = name;
            HasRibbon = false;
            RibbonCount = count;
        }

        public int MaxCount
        {
            get
            {
                if (RibbonCount < 0)
                    return -1;
                switch (Name)
                {
                    case nameof(IRibbonSetCommon6.RibbonCountMemoryContest):
                        return 40;
                    case nameof(IRibbonSetCommon6.RibbonCountMemoryBattle):
                        return 8;
                    default:
                        return 4; // g3 contest ribbons
                }
            }
        }

        public static IReadOnlyList<RibbonInfo> GetRibbonInfo(PKM pkm)
        {
            // Get a list of all Ribbon Attributes in the PKM
            var riblist = new List<RibbonInfo>();
            var names = ReflectUtil.GetPropertiesStartWithPrefix(pkm.GetType(), "Ribbon");
            foreach (var name in names)
            {
                object RibbonValue = ReflectUtil.GetValue(pkm, name);
                if (RibbonValue is int x)
                    riblist.Add(new RibbonInfo(name, x));
                if (RibbonValue is bool b)
                    riblist.Add(new RibbonInfo(name, b));
            }

            return riblist;
        }
    }
}
