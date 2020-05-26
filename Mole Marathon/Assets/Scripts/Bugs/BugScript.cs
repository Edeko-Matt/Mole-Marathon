using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugScript : MonoBehaviour
{
    
    Rigidbody bug;
    Vector3 bugPosition;
    Vector3 molePos;
    Vector3 bugDestination;
    GameObject mole;
    Transform moleTransform;
    float distance;
    int bugs;

    void Start()
    {
        bug = gameObject.GetComponent<Rigidbody>();
        bug.useGravity = false;
        bugPosition = new Vector3(10f, -5f, -1f);
        bugDestination = new Vector3(25f, -5f, -1f);
        mole = GameObject.FindGameObjectWithTag("character");
        moleTransform = mole.transform;
        molePos = moleTransform.position;
        bug.drag = 2.5f;
        
    }

   
    void Update()
    {
        
        mole = GameObject.FindGameObjectWithTag("character");
        moleTransform = mole.transform;
        molePos = moleTransform.position;
        consumed();
       
    }

    void consumed()
    {
       
        bugPosition = Vector3.MoveTowards(transform.position, bugDestination, 0.05f);
        bug.AddForce(transform.right);
        distance = Vector3.Distance(transform.position, molePos);

        if (distance <= 1.2f)
        {
            switch(this.name)
            {
                case "y":
                    Inventory.yellowBugs++;
                    gameObject.GetComponent<Renderer>().enabled = false;
                    gameObject.transform.position = new Vector3(-500, -500, -500);
                    StartCoroutine("Pause");
                    break;
                case "r":
                    Inventory.redBugs++;
                    gameObject.GetComponent<Renderer>().enabled = false;
                    gameObject.transform.position = new Vector3(-500, -500, -500);
                    StartCoroutine("Pause");
                    break;
                case "b":
                    Inventory.blueBugs++;
                    gameObject.GetComponent<Renderer>().enabled = false;
                    gameObject.transform.position = new Vector3(-500, -500, -500);
                    StartCoroutine("Pause");
                    break;
                case "g":
                    Inventory.greenBugs++;
                    gameObject.GetComponent<Renderer>().enabled = false;
                    gameObject.transform.position = new Vector3(-500, -500, -500);
                    StartCoroutine("Pause");
                    break;
            }

        }

    }

    IEnumerator Pause()
    {
        enabled = false;

        yield return new WaitForSeconds(.7f);

        enabled = true;

    }

}
