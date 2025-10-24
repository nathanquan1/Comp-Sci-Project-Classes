using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troop : MonoBehaviour
{
    //Array.IndexOf(TroopNames, input);
    public static string[] TroopNames = { "Tung Tung Tung Sahur","" };
    public static int[] Cost = { 3 ,0};
    public static int[] Damage = { 100000 ,0};
    public static int[] Health = { 1, 0 };

    private int _health;
    private int _damage;
    private int _x;
    private int _y;
    public Troop(int x, int y)
    {
        this._x = x;
        this._y = y;
    }
    
    void Update()
    {
        //walk towards enemy
        
    }
}
