using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player_test;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Player_test.position);
        transform.position = Player_test.position + offset;
    }
}
