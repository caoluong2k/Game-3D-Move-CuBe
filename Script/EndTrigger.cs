using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EndTrigger : MonoBehaviour
{
    public GameManager _gameManager;

    void OnTriggerEnter(Collider col)
    {
        _gameManager.CompleteLevel();
    }
}
