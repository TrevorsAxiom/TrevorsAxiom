using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour 
{
    [System.Serializable]
    public class Playerstats
   
    {
         [Range (0,90)] public float Health = 100f;
          

    }

    private Rigidbody rb;

        void start () {
        rb = GetComponent<Rigidbody> ();
    }


    public Playerstats playerstats = new Playerstats ();

    public void DamagePlayer (float damage) 
 {
     playerstats.Health -= damage;
     if (playerstats.Health <= 0) 
     {
          GameMaster.KillPlayer(this.gameObject);
     }
 }
 

        void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Water")

        {
            DamagePlayer (Mathf.Infinity);
            Debug.Log("Player damaged");
            //Destroy (gameObject);


        }
        
    }
    
}


    /* private Rigidbody rb;

    void start () {
        rb = GetComponent<Rigidbody> ();
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Water")
        {
            Destroy (gameObject);

        }
        
    }

    public Transform Player;
    public Transform spawnPoint;

    public void RespawnPlayer () 
    {
        Instantiate (Player, spawnPoint.position, spawnPoint.rotation);
        Debug.Log ("TODD; Add spawn particles");
        
    }*/

   

   

