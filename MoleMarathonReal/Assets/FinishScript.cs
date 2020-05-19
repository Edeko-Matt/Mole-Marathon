using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{

    Rigidbody bush;
    Vector3 bushPosition;
    Vector3 molePos;
    GameObject mole;
    Transform moleTransform;
    float distance;

    void Start()
    {
        bush = gameObject.GetComponent<Rigidbody>();
        bush.useGravity = false;
        bushPosition = new Vector3(10f, 0f, -1f);
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
        SceneManager.LoadScene("LevelSelect");
    }

    IEnumerator Pause()
    {
        enabled = false;

        yield return new WaitForSeconds(.7f);

        enabled = true;

    }
}