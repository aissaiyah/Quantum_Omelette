using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1, 0, 0);
            if (Physics2D.OverlapCircle(transform.position,.2f))
            {
                transform.Translate(-1, 0, 0);
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1, 0, 0);
            if (Physics2D.OverlapCircle(transform.position, .2f))
            {
                transform.Translate(1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 1, 0);
            if (Physics2D.OverlapCircle(transform.position, .2f))
            {
                transform.Translate(0, -1, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, -1, 0);
            if (Physics2D.OverlapCircle(transform.position, .2f))
            {
                transform.Translate(0, 1, 0);
            }
        }
    }
}
