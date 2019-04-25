using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendMessage : MonoBehaviour
{
    [SerializeField] GameObject frame;
    [SerializeField] InputField inputField;
    [SerializeField] Transform ChatArea;

    void Start()
    {

    }

    void Update()
    {

    }

    public void SendMassage()
    {
        if (inputField.text != "")
        {
            GameObject clone = Instantiate(frame, ChatArea);
            clone.transform.GetChild(0).gameObject.GetComponent<Text>().text = inputField.text;
            inputField.text = "";
        }
    }
}
