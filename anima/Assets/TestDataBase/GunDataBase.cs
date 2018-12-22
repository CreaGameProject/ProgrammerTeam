using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GunDataBase", menuName = "CreateGunDataBase")]
public class GunDataBase : ScriptableObject
{

    [SerializeField]
    private List<Gun> gunLists = new List<Gun>();

    //　アイテムリストを返す
    public List<Gun> GetGunLists()
    {
        return gunLists;
    }
}