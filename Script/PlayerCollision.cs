using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    //public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle !!!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        //Debug.Log(collistionInfo.collider.name);

        //LevelControl.instance.youLose();
    }
}
