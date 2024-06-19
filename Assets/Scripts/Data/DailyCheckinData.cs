using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyCheckinData : ScriptableObject
{
    public DailyCheckinData[] dailyCheckinDatas;
    [Serializable]
    public struct DailyCheckin
    {
        public int day;
        public ReWard[] rewards;
    }
}
[Serializable]
public struct ReWard
{
    public int rewardType;
    public int rewardId;
    public int rewardNumber;
}
public enum ReWardType
{
    None = 0,
    Gold = 1,
    Skil = 2
}