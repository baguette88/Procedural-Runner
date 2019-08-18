
using UnityEngine;

public class Ender : MonoBehaviour
{

 //   public Player movement;


    void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Enemy")
        {
        //    movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}