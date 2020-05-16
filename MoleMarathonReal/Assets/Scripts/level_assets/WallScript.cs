using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public Transform player;
    public Rigidbody pBody;
    public Transform fox;
    public Rigidbody fBody;
    private Vector3 position;
    private bool falling;

    void Start()
    {
        
    }
    

    void Update()
    {
        position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        playerCollisionDetection(player,pBody,false);
        playerCollisionDetection(fox,fBody,true);
    }

    private void playerCollisionDetection(Transform movement,Rigidbody force,bool notPlayer)
    {
        Vector3 tempPosition = new Vector3(movement.position.x, 0f, movement.position.z);

        // left side
        if (movement.position.x <= transform.position.x && movement.position.x >= transform.position.x - 0.6f)
        {

            if (movement.position.y >= transform.position.y && movement.position.y <= transform.position.y + 1.5f) //height
            {
                position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
                movement.position = position;
                force.isKinematic = true;

                if (notPlayer == true)
                {
                    force.isKinematic = false;
                    force.AddForce(0f, 1000f, 0f);
                    force.useGravity = true;

                    if (movement.position.y > 3)
                    {
                        falling = true;
                    }
                    if (falling = true && movement.position.y >= 0f && movement.position.y <= 1f)
                    {
                        movement.position = tempPosition;
                        force.useGravity = false;
                    }
                }
                else if (notPlayer == false && Input.GetKey(KeyCode.UpArrow))
                {
                    force.isKinematic = false;
                    force.AddForce(0f, 900f, 0f);
                }

            }
            else if(this.position.y == 0)
            {
                position = new Vector3(transform.position.x -0.6f, 0f, transform.position.z);
                movement.position = position;
                force.isKinematic = true;
                force.isKinematic = false;

                if (notPlayer == true)
                {
                    force.isKinematic = false;
                    force.AddForce(0f, 1000f, 0f);
                    force.useGravity = true;

                    if (movement.position.y > 6)
                    {
                        falling = true;
                    }
                    if (falling = true && movement.position.y >= 0f && movement.position.y <= 1f)
                    {
                        movement.position = tempPosition;
                        force.useGravity = false;
                    }
                }
            }
        }

        //right side
        if (movement.position.x >= transform.position.x && movement.position.x <= transform.position.x + 0.6f)
        {
            if (movement.position.y <= transform.position.y && movement.position.y >= transform.position.y + 1.5f) //height
            {
                position = new Vector3(transform.position.x - 1, transform.position.y + 1.5f, transform.position.z);
                movement.position = position;
                force.isKinematic = true;

                if (notPlayer == true)
                {
                    force.isKinematic = false;
                    force.AddForce(0f, 1000f, 0f);
                    force.useGravity = true;

                    if (movement.position.y > 6)
                    {
                        falling = true;
                    }
                    if (falling = true && movement.position.y >= 0f && movement.position.y <= 1f)
                    {
                        movement.position = tempPosition;
                        force.useGravity = false;
                    }
                }

                else if (notPlayer == false && Input.GetKey(KeyCode.UpArrow))
                {
                    force.isKinematic = false;
                    force.AddForce(0f, 700f, 0f);
                }
            }
            else if (movement.position.y == 0)
            {
                position = new Vector3(transform.position.x + 0.6f, 0f, transform.position.z);
                movement.position = position;
                force.isKinematic = true;
                force.isKinematic = false;

                if (notPlayer == true)
                {
                    force.isKinematic = false;
                    force.AddForce(0f, 1000f, 0f);
                    force.useGravity = true;

                    if (movement.position.y > 6)
                    {
                        falling = true;
                    }
                    if (falling = true && movement.position.y >= 0f && movement.position.y <= 1f)
                    {
                        movement.position = tempPosition;
                        force.useGravity = false;
                    }
                }
            }
        }
    }
}
