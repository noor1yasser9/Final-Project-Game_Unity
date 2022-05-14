using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batCode : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject playerObject;
    Vector3 startPoint;
    void Start()
    {
        startPoint = transform.position;
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject == null) {
            playerObject = GameObject.FindGameObjectWithTag("Player");
        }
        else
        {
            float distance = Vector3.Distance(startPoint, playerObject.transform.position);
            if (distance < 4)
            {
                transform.position = Vector3.MoveTowards(transform.position, 	  playerObject.transform.position, 0.01f);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, startPoint, 0.01f);
            }
        }        
    }
}
