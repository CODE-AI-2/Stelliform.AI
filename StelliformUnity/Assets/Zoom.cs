using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float speed;
    public Transform Camera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Camera.transform.Translate(Vector3.up * speed* Time.deltaTime);

        }
        if (Input.GetKeyDown("s"))
        {
            Camera.transform.Translate(Vector3.down * speed* Time.deltaTime);

        }
        if (Input.GetKeyDown("a"))
        {
            Camera.transform.Translate(Vector3.left *speed* Time.deltaTime);

        }
        if (Input.GetKeyDown("d"))
        {
            Camera.transform.Translate(Vector3.right *speed* Time.deltaTime);

        }
    }
    public void ZoomIn()
    {
        if (transform.position.z <= -10)
        {
            Camera.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10);
        }

    }
    public void ZoomOut()
    {
        if (transform.position.z >= -150)
        {
            Camera.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);
        }

    }


    
}
