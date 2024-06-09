﻿using System;

namespace RollingRush.Saving
{
    [Serializable]
    public class LevelProgress
    {
        public float recordTime = float.MaxValue - 1f;
        public bool gotStarForLevelCompletion;
        public bool gotStarForFastCompletion;
        public bool gotStarForCollectingCoins;
    }
}