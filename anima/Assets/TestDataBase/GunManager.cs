using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour {

    [SerializeField] private GunDataBase gunDataBase;

    private Dictionary<Gun, int> numOfGun = new Dictionary<Gun, int>();

	// Use this for initialization
	void Start () {
        for (int i = 0; i < gunDataBase.GetGunLists().Count; i++)
        {
            numOfGun.Add(gunDataBase.GetGunLists()[i], i);
            Debug.Log(gunDataBase.GetGunLists()[i].GetGunName());

        }

	}
	
	// Update is called once per frame
	public Gun GetItem(string searchName)
    {
        return gunDataBase.GetGunLists().Find(gunName => gunName.GetGunName() == searchName);
    }
}
