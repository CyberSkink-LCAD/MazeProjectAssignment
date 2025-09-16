using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Y : MonoBehaviour
{
    public float winRadius = 5.5f;
    //Define Win Radius
    public Vector3 winPos = new Vector3(-39.93584f, 0.41f, -41.27f);
    //Define win zone center position
    public int health = 10;
    // Define player health
    private Rigidbody rb;

    public float speed = 3.0f;

    public float winDis;
    //Win distance does not get defined yet
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 plCurrentPos = transform.position;
        //Define plater postion
        float h = Input.GetAxis("Horizontal"); //variable for moving on the horizontal axis
        float v = Input.GetAxis("Vertical"); //variable for moving on the vertical axis

        Vector3 move = new Vector3(h, 0, v);
        rb.AddForce(move * speed);
        winDis = Vector3.Distance(winPos,plCurrentPos);
            //define win distance here.
        if (winDis <= winRadius)
        {
            SceneManager.LoadScene(2);
        }
        if (health <= 0)
        {
            SceneManager.LoadScene(0);
        }

    }
}
