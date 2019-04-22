using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> cards;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private GameObject SelectCard()
    {
        GameObject card = cards[Random.Range(0, cards.Count)];
        cards.Remove(card);
        return card;
    }
}
