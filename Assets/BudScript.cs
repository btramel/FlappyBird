using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BudScript : MonoBehaviour
{

    // creates reference to Rigidbody
    public Rigidbody2D myRigidbody;
    // creates variable in Unity to toggle instead of moving back and forth between code and Unity
    public float flapStrength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) {
        myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
}
