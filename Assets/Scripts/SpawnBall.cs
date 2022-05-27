using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public static SpawnBall instance;

    public GameObject ball;
    public float ballForce = 700;
    public float spawnHelper = 4.5f;

    public Camera _cam;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }
    void Start()
    {
        _cam = GetComponent<Camera>();
    }
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            if(GameControll.instance.ballsCount > 0)
            MouseClick();
        }
    }

    //Spawn ball on click
    private void MouseClick()
    {
        //Count balls
        GameControll.instance.ballsCount--;
        GameControll.instance.text_score.text = "" + GameControll.instance.ballsCount;

        //Mouse coordinates on the screan (ex: x = (-512 ; 512), but not (0 ; 1024))
        float mousePosY = _cam.pixelHeight / 2 - _cam.pixelHeight + Input.mousePosition.y;
        float mousePosX = _cam.pixelWidth / 2 - _cam.pixelWidth + Input.mousePosition.x;
        //Debug.Log("\nCamera Size X: " + mousePosX + "\tCamera Size Y: " + mousePosY);

        //Spawn an object and giving impetus
        GameObject ballRigid;
        ballRigid = Instantiate(ball, new Vector3(transform.position.x + 0.3f, transform.position.y - 0.2f, transform.position.z), transform.rotation);
        ballRigid.GetComponent<Rigidbody>().AddForce(new Vector3(1, mousePosY / _cam.pixelHeight * 1.3f , mousePosX / -_cam.pixelWidth * 1.75f) * ballForce);
    }
}
