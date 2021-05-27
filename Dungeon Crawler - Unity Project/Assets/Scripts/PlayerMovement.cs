using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variable, visible in unity inspector
    public float forceStrength;
    
    //public functions to be called by each of the buttons
    public void MoveUp()
    {
        //get the rigibody that well be ysing fro the movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //move in the correc direction with the set force strength
        ourRigidbody.AddForce(Vector2.up * forceStrength);
    }
    public void MoveLeft()
    {
        //get the rigibody that well be ysing fro the movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //move in the correc direction with the set force strength
        ourRigidbody.AddForce(Vector2.left * forceStrength);
    }
    public void MoveDown()
    {
        //get the rigibody that well be ysing fro the movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //move in the correc direction with the set force strength
        ourRigidbody.AddForce(Vector2.down * forceStrength);
    }
    public void MoveRight()
    {
        //get the rigibody that well be ysing fro the movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //move in the correc direction with the set force strength
        ourRigidbody.AddForce(Vector2.right * forceStrength);
    }
}
