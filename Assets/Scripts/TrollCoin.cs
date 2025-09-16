using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity.VisualScripting;
using UnityEngine;

public class TrollCoin : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collector)
    {

        if (collector.gameObject == collector.gameObject.CompareTag("Player"))
        {

            collector.GetComponent<Y>().health -= 10;
            Destroy(this.gameObject);
            //I am the angry pumpkin
        }
    }
}
