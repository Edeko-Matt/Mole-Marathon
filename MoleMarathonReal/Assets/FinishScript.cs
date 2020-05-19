using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    Rigidbody finish;
    Vector3 finishPosition;
    Vector3 molePos;
    GameObject mole;
    Transform moleTransform;
    float distance;

    void Start()
    {
        finish = gameObject.GetComponent<Rigidbody>();
        finish.useGravity = false;
        finishPosition = new Vector3(13.67841f, 0.1441803f, -0.3049797f);
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
            SceneManager.LoadScene("Scenes/LevelSelect");
        }
    }

}