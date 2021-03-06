﻿using System;
using System.Collections.Generic;
using UnityEngine;

//Buff池，用于存放所有技能的数据
public static class BuffPool
{
    public static List<Buff> passiveSkills = new List<Buff>();

    public static bool loadComplete = false;

    //public static void LoadPassiveSkills()
    //{
    //    Debug.Log("load complete!");
    //    passiveSkills.Add(new ShelterOfLight());//1
    //    loadComplete = true;
    //}

    public static Buff getPassiveSkills(int index)
    {
        //被动池用于分发被动技能
        switch(index)
        {
            case 0://阿尔萨斯
                return new ShelterOfLight();
            case 1://克罗米
                return new FutureGuardian();
            case 2://乌瑟尔
                return new HolyHalo();
            case 3://吉安娜
                return new SealingIce();
            case 99://马儿甘尼斯
                return new Burning();
            default:
                return new NoSkills();
        }
        //Debug.Log("the unit has skill:" + index);
        //return passiveSkills[index];
    }

    public static Skill getActiveSkills(int index)
    {
        //被动池用于分发主动技能
        switch (index)
        {
            case 0://阿尔萨斯 - > 圣裁
                return new SacredRuling();
            case 1://希尔瓦娜斯 -> 贯穿
                return new Hunting();
            case 2://克罗米 -> 跳舞
                return new Dance();
            case 3://吉安娜 -> 冰华
                return new Glimmer();
            case 4://乌瑟尔 -> 圣光的祝福
                return new BlessingofHolyLight();
            case 5://穆拉丁 -> 血仇
                return new BloodFeud();
            default:
                return new SacredRuling();
        }
        //Debug.Log("the unit has skill:" + index);
        //return passiveSkills[index];
    }

}
