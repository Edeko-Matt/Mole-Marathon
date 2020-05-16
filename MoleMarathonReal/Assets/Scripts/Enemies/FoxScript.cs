using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoxScript : MonoBehaviour
{
    private Rigidbody body = new Rigidbody();
    private Vector3 position;
    private float areaOfTrigger;
    public static int health;
    public Transform target;
    public Text Damage;
    
   
    
    
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
        body.useGravity = false;
        areaOfTrigger = 1f;
        health = 5;
        position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        body.freezeRotation.Equals(true);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        body.AddForce(-0.5f, 0f, 0f);

        if (target.position.x <= transform.position.x)
        {
            if (target.position.x > transform.position.x - areaOfTrigger)
            {
                if (target.position.y == transform.position.y)
                {
                    healthSystem();
                    StartCoroutine("Pause");
                }
            }
        }
    }

    public void healthSystem()
    {
        health--;

        switch (health)
        {
            case 0:
                Damage.text = "GAME OVER!";
                GameOver.popUp.enabled = true;
               // gameOver.enabled = true;
                //SceneManager.LoadScript("Menu");
                body.isKinematic = true;
                break;

            case 1:
                Damage.text = "❤";
                break;

            case 2:
                Damage.text = "❤ ❤";
                break;
            case 3:
                Damage.text = "❤ ❤ ❤";
                break;
            case 4:
                Damage.text = "❤ ❤ ❤ ❤";
                break;
            case 5:
                Damage.text = "❤ ❤ ❤ ❤ ❤";
                break;


        }

       print(health);
    }
    IEnumerator Pause()
    {
        enabled = false;

        yield return new WaitForSeconds(.7f);
        
        enabled = true;

    }

}
