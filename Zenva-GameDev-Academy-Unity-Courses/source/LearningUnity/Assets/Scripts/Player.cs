using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealth(int value) {
        health += value;
        Debug.Log($"Player Health {health} HP ({value})");
    }

    void OnMouseDown() {
        UpdateHealth(-10);
    }
}
