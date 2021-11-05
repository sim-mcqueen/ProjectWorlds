/////////////////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/2/21
//// Proj: ProjectWorlds
//// Desc: Gives instructions to the end line gameobject to switch scenes once the level has been cleared
/////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLine : MonoBehaviour
{
    private int EnemiesLeft;
    private bool readyToGo = false;

    public string NextLevel;

    // Start is called before the first frame update
    void Start()
    {
        EnemyScript[] arrayOfEnemies = FindObjectsOfType<EnemyScript>();
        EnemiesLeft = arrayOfEnemies.Length;
        FindObjectOfType<EnemyCounterText>().UpdateText(EnemiesLeft);
    }

    public void EnemyKilled()
    {
        EnemiesLeft--;
        if(EnemiesLeft <= 0)
        {
            readyToGo = true;
        }
        FindObjectOfType<EnemyCounterText>().UpdateText(EnemiesLeft);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(readyToGo)
            {
                SceneManager.LoadScene(NextLevel);
            }
        }
    }


}
