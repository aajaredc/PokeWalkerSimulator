﻿namespace PKHeX.Core
{
    public interface IGCSaveFile
    {
        bool IsMemoryCardSave { get; }
    }

    public static class GCSaveExtensions
    {
        public static string GCFilter(this IGCSaveFile gc)
        {
            const string regular = "GameCube Save File|*.gci|All Files|*.*";
            const string memcard = "Memory Card Raw File|*.raw|Memory Card Binary File|*.bin|";
            return gc.IsMemoryCardSave ? memcard + regular : regular;
        }

        public static string GCExtension(this IGCSaveFile gc) => gc.IsMemoryCardSave ? ".raw" : ".gci";
    }
}