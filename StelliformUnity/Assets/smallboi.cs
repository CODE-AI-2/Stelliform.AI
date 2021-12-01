using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallboi : MonoBehaviour {

    public GameObject yeet;
    // Start is called before the first frame update
    void Start()
    {
        yeet.SetActive(false);
    }

    // Update is called once per frame
    public void yeetus1()
    {
    yeet.SetActive(true);   
    }
    public void yeetus2()
    {
        yeet.SetActive(false);
    }
}
