using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;


    void Start ()
    {
        if (gm == null) {
            gm = GameObject.FindGameObjectWithTag ("GM").GetComponent<GameMaster>();
        }

    }

    public Transform Player;
   
    public static void KillPlayer (GameObject Player) 
    {
        Destroy (Player.gameObject);
        SceneManager.LoadScene("GameOver");
        //Application.LoadLevel(Application.loadedLevel);
        //gm.SceneManager();
    
    }




    }
