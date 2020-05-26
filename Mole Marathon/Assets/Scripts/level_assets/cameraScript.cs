using UnityEngine;

public class cameraScript : MonoBehaviour
{

    public Transform target;
    public float smoothspeed = 0f;
    public Vector3 offset;
    public bool popUpIsOn = false;
    public Canvas pause;

    void Start()
    {
        popUpIsOn = false;
        offset = new Vector3(0f, 0f, -10f);
        pause = GameObject.FindGameObjectWithTag("pause").GetComponent<Canvas>();
        pause.planeDistance = 0;
    }

    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
        transform.position = target.position + offset;
       pauseGame();

    }

    void pauseGame()
    {
        if (Input.GetKeyDown(KeyCode.P) && popUpIsOn == false)
        {
           
            pause.planeDistance = 10;
            popUpIsOn = true;
            Time.timeScale = 0f;
         
        }
        else if (Input.GetKeyDown(KeyCode.P) && popUpIsOn == true)
        {
            
            pause.planeDistance = 0;
            popUpIsOn = false;
            Time.timeScale = 1;
          
        }

    }
}
