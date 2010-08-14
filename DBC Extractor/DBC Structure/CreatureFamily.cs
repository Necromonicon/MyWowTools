﻿using System;
using System.Runtime.InteropServices;

namespace DbcExtractor
{
    [StructLayout(LayoutKind.Sequential)]
    [TableName("pet_family")]
    struct CreatureFamily
    {
        [PrimaryKey]
        public uint Id;
        private float minScale;
        private uint minScaleLevel;
        private float maxScale;
        private uint maxScaleLevel;
        public uint skillLine1;
        public uint skillLine2;
        public uint petFoodMask;
        public int petType;
        public int category;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.TotalLocales)]
        [DBCString(true)]
        public uint[] name;
        private uint nameflags;
        [DBCString(false)]
        public uint IconName;
    }
}
