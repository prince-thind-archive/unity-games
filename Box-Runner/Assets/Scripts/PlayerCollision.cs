
using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   public PlayerMovement script;

   void OnCollisionEnter(Collision col)
   {
      if (col.collider.tag == "Obstacle")
      {
        script.enabled = false;
        FindObjectOfType<GameController>().GameClose();
      }
   }

   private void OnTriggerEnter(Collider col)
   {
       FindObjectOfType<GameController>().NewLevel();
   }
}
