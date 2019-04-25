using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isShooting;
    [SerializeField] private float sensitivity;//感度
    [SerializeField] private float shootSpan;//発射レート
    //[SerializeField] private GameObject card;
    [SerializeField] private List<GameObject> cards;
    [SerializeField] private GameObject muzzle;
    [SerializeField] private GameObject gun;

    void Start()
    {
        isShooting = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        StartCoroutine(LoadCards());
        StartCoroutine(ControlShooting());
    }

    void Update()
    {
        //射撃の切り替え
        if (Input.GetKeyDown(KeyCode.Mouse0))
            isShooting = true;
        if (Input.GetKeyUp(KeyCode.Mouse0))
            isShooting = false;
        //回転
        float y = Input.GetAxis("Mouse X");
        float x = Input.GetAxis("Mouse Y");
        transform.Rotate(0, y * sensitivity, 0);
        gun.transform.Rotate(-x, 0, 0);
    }
    

    //Resourcesフォルダからカードのオブジェクトを一括ロード
    private IEnumerator LoadCards()
    {
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 13; j++)
            {
                string cardName = "PlayingCards_";
                switch (j)
                {
                    case 10:
                        cardName += "J";
                        break;
                    case 11:
                        cardName += "Q";
                        break;
                    case 12:
                        cardName += "K";
                        break;
                    case 0:
                        cardName += "A";
                        break;
                    default:
                        cardName += (j + 1).ToString();
                        break;
                }

                switch (i)
                {
                    case 0:
                        cardName += "Club";
                        break;
                    case 1:
                        cardName += "Diamond";
                        break;
                    case 2:
                        cardName += "Heart";
                        break;
                    case 3:
                        cardName += "Spades";
                        break;
                    default:
                        break;
                }
                GameObject card = (GameObject)Resources.Load(cardName);
                card.GetComponent<Rigidbody>().useGravity = false;
                cards.Add(card);
                yield return null;
            }
        }
    }

    //射撃の制御
    //左クリックを押したときに射撃開始
    //左クリックを離したときに射撃終了
    private IEnumerator ControlShooting()
    {
        while (true)
        {
            if (isShooting)
            {
                ShootCard();
                yield return new WaitForSeconds(shootSpan);
            }
            else
            {
                yield return null;
            }
        }
    }

    //ロードしたカードのオブジェクトからランダムに選び、射撃する
    private void ShootCard()
    {
        GameObject card = Instantiate(cards[Random.Range(0, cards.Count)], muzzle.transform.position, gun.transform.rotation);
        card.GetComponent<Rigidbody>().AddForce(card.transform.forward * 50, ForceMode.VelocityChange);
        
    }


}