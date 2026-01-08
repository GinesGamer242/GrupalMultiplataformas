using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player player;
    public SceneAsset Menu;
    public SceneAsset Win;
    public SceneAsset Loss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.points >= 2000)
        {
            SceneManager.LoadScene(Win.name);
        }

        if(player.health < 0)
        {
            SceneManager.LoadScene(Loss.name);
        }
    }
}
