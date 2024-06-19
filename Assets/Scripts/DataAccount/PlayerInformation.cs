using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformation
{
    public int score;
    public int capdo;
    public int kinhnghiem;
    public void ChangeScore(int newscore)
    {
        if (newscore > score)
        {
            score = newscore;
            DataAccountPlayer.SavePlayerInfomation();
        }
    }
    public void SaveLevel(int newlevel)
    {
        if(newlevel > capdo)
        {
            capdo = newlevel;
            DataAccountPlayer.SavePlayerInfomation();
        }
    }
    public void SaveEX(int nowEx)
    {
        if(nowEx > kinhnghiem) 
        {
            kinhnghiem = nowEx;
            DataAccountPlayer.SavePlayerInfomation(); 
        }
    }
}
