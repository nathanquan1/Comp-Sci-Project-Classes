using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Data.Common; //Text Mesh Pro
using System;
public class Player_Actions : MonoBehaviour
{
    private int _energy; //private so the enemy has energy amount too
    public float timer = 0;
    public TextMeshProUGUI ElixirAmount;
    void Start()
    {
        this._energy = 7;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //EVERY FRAME: checks if has been 2 seconds or more than increases elixir by 1 and then resets timer to 0
        if (timer >= 2)
        {
            timer = 0;
            if (this._energy < 10){
                this._energy += 1;
            }
            
        }
        ElixirAmount.text = $"{this._energy}"; //update text on screen
    }

    public void UseCard(string name) //make it take mouse x and y 
    {
        int index = Array.IndexOf(Troop.TroopNames, name); //finds index number of whatever troop you want to play so you can get their stats
        if (this._energy >= Troop.Cost[index])
        {
            this._energy -= Troop.Cost[index];
            Troop _ = new Troop(0, 0);
        }
        
    }
    
}
