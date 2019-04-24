using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataSaverWithJson : MonoBehaviour
{
    private Root root;
    [SerializeField] private GameObject itemPrefab;
    void Start()
    {
        Load();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            Save();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            InstantiateAtRandomPosition();
        }
    }

    //アイテムをランダムな場所に生成する
    private void InstantiateAtRandomPosition()
    {
        GameObject item = Instantiate(itemPrefab, new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);
        
    }

    //データを所有しているオブジェクトを全部取得して、データを取ってきて保存
    private void CollectData()
    {
        root = new Root();
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Item");
        //if(root == null)
        //{
        //    Debug.Log("Root is null");
        //}
        //if (root.items == null)
        //    Debug.Log("Items is null");
        for(int i = 0; i < gameObjects.Length; i++)
        {
            Item item = gameObjects[i].GetComponent<SaveData>().item;
            //if (item == null)
            //    Debug.Log("Item is null");
            root.items.Add(item);
        }
    }

    //取ってきたデータをもとにJSONファイルを作成
    private void Save()
    {
        CollectData();
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.dataPath + "/SaveData");
        if (directoryInfo.Exists == false)
            directoryInfo.Create();
        FileInfo fileInfo = new FileInfo(Application.dataPath + "/SaveData/Data.json");
        if (fileInfo.Exists == false)
        {
            fileInfo.Create();
        }



        using(StreamWriter streamWriter = new StreamWriter(Application.dataPath + "/SaveData/Data.json"))
        {
            string data = JsonUtility.ToJson(root);
            streamWriter.Write(data);
        }
    }

    //作成されたJSONファイルを読み込んで、そこからデータを抽出して読み込み
    private void Load()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.dataPath + "/SaveData");
        if (directoryInfo.Exists == false)
            directoryInfo.Create();
        FileInfo fileInfo = new FileInfo(Application.dataPath + "/SaveData/Data.json");
        if(fileInfo.Exists == false)
        {
            fileInfo.Create();
        }
        else
        {
            using(StreamReader streamReader = new StreamReader(Application.dataPath + "/SaveData/Data.json"))
            {
                string data = streamReader.ReadToEnd();
                root = JsonUtility.FromJson<Root>(data);
            }

            if(root != null)
                //ロードしたデータからアイテムを生成
                foreach(Item item in root.items)
                {
                    GameObject gameObject = Instantiate(itemPrefab, item.pos, Quaternion.identity);
                    gameObject.GetComponent<SaveData>().item = item;
                    gameObject.name = item.name;
                    gameObject.tag = "Item";
                }
        }
    }

}
