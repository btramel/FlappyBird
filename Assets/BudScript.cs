using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class BudScript : MonoBehaviour
{

    // creates reference to Rigidbody
    public Rigidbody2D myRigidbody;
    // creates variable in Unity to toggle instead of moving back and forth between code and Unity
    public float flapStrength;
    public GameLogic logic;
    public bool budIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && budIsAlive) {
        myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        budIsAlive = false;
        logic.gameOver();
    }
}
