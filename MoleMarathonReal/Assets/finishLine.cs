using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    Rigidbody finish;
    Vector3 finishPosition;
    Vector3 molePos;
    Vector3 finishDestination;
    GameObject mole;
    Transform moleTransform;
    float distance;

    void Start()
    {
        finish = gameObject.GetComponent<Rigidbody>();
        finish.useGravity = false;
        finishPosition = new Vector3(49.99f, 0.86f, 0f);
        mole = GameObject.FindGameObjectWithTag("character");
        moleTransform = mole.transform;
        molePos = moleTransform.position;
    }


    void Update()
    {

        mole = GameObject.FindGameObjectWithTag("character");
        moleTransform = mole.transform;
        molePos = moleTransform.position;
        finished();

    }

    void finished()
    {
        distance = Vector3.Distance(transform.position, molePos);

        if (distance <= 1.2f)
        {
            SceneManager.LoadScene("LevelSelect");

        }

    }

    IEnumerator Pause()
    {
        enabled = false;

        yield return new WaitForSeconds(.7f);

        enabled = true;

    }
}
