using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.IO;

//AssetsにResourcesを作りそこにCSVファイルを置いておく
public class CSVreader : MonoBehaviour {

    TextAsset csvFile;
    List<string[]> Items = new List<string[]>();

	void Start () {
        csvFile = Resources.Load("") as TextAsset;//""の中にはファイル名を入れる
        StringReader reder = new StringReader(csvFile.text);
        while (reder.Peek() != -1)
        {
            string line = reder.ReadLine();
            Items.Add(line.Split(','));
        }
        Debug.Log(Items[0][0]);
        Debug.Log(Items[0][1]);
        Debug.Log(Items[1][0]);
        Debug.Log(Items[2][0]);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
