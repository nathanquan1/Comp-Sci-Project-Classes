using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Deck : MonoBehaviour
{
    private string[] _deck = { };
    void Start()
    {
        
    }
    void Update()
    {

    }

    public Deck(string[] Deck)
    {
        this._deck = Deck;
    }
    public Deck CreateStarter()
    {
        return new Deck(new string[]{"CARD1", "CARD2"});
    }
}
