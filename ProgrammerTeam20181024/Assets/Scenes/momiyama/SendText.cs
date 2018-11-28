using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendText : MonoBehaviour {

    [SerializeField]
    List<string> messages;

    [SerializeField]
    UnityEngine.UI.Text messageBox;

    private List<string>.Enumerator enumerator;

    private int current = 0;

    // Use this for initialization
    void Start () {
        enumerator = messages.GetEnumerator();

        OnClick();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            OnClick();
        }

	}

    public void OnClick()
    {
        if (enumerator.MoveNext())
            messageBox.text = enumerator.Current;
    }
}
