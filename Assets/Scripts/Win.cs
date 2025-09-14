using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public float winRadius = 5.5f;
    //Define Win Radius
    public Vector3 winPosition = new Vector3(-50.2f, 3.16f, 1.040987f);
    // Start is called before the first frame update
    public float winDistance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 plCurrentPos = transform.position;
        winDistance = Vector3.Distance(winPosition, plCurrentPos);
        //define win distance here.
        if (winDistance <= winRadius)
        {
            SceneManager.LoadScene(3);
        }
    }

}
