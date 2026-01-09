using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 100;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void getHit()
    {
        health -= 10;
    }

    public void AddPoints(int amount)
    {
        points += amount;
    }
}
