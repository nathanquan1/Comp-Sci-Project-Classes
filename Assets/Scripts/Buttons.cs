using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    //Deck starter = Deck.CreateStarter();
    
    void Start()
    {
        
    }
    void Update()
    {

    }


    public void Play()
    {
        //Doesnt work idk why
        SceneManager.LoadScene("Game");
        Debug.Log("play");
    }

    
    /*
    public void AddCard(Deck Deck, int CardSlot)
    {
        //deck.changecard(CardSlot)
    }
    public void NewDeck()
    {
        //check if you own cardsin for loop
        Deck a = new Deck(new string[]{"a" });
    }
    */
}
