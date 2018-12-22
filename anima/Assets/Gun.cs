using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[SerializeField] [CreateAssetMenu(fileName = "Gun", menuName = "CreateGun")]


public class Gun : ScriptableObject {

    //銃の種類の登録
    public enum KindOfGun
    {
        SniperRifle=1,
        ShotGun
    }

    
    //銃の種類の選択
    [SerializeField] private KindOfGun kindOfGun;

    [SerializeField] private bool single;
  
    //銃の名前
    [SerializeField] private string gunName;

    //銃の射程
    [SerializeField] private int range;

    //銃の基礎威力
    [SerializeField] private int power;
    
    //リロード時間
    [SerializeField] private int relordTime;

    //最大所持段数
    [SerializeField] private int bringBullets;

    //最大装填弾数
    [SerializeField] private int maxBullets;

    //以下　銃の情報呼び出し
    public KindOfGun GetKindOfGun()
    {
        return kindOfGun;
    }
    public string GetGunName()
    {
        return gunName;
    }
    public int GetRange()
    {
        return range;
    }
    public int GetPower()
    {
        return power;
    }
    public bool GetSingle()
    {
        return single;
    }
    
}
