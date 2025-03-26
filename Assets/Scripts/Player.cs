using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Character character;

    private void Start()
    {
        GameManager.Instance.Player = this;
    }
}
