﻿
namespace GameUtils
{
    public enum WeaponType
    {
        SAW,
        GUN,
        TEDDY_BEAR
    };

    public struct WeaponSelection
    {
        public WeaponType weaponType;
        public int player;
    }
}