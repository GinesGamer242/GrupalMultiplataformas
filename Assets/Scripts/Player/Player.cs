using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 100;
    public int points = 0;

    public void getHit()
    {
        health -= 10;

        if (health <= 0f)
            GameManager.instance.onPlayerLose.Invoke();
    }

    public void AddPoints(int amount)
    {
        points += amount;

        if (points >= 2000)
            GameManager.instance.onPlayerWin.Invoke();
    }
}
