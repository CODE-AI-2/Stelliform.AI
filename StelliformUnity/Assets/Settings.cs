using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject object1;

    private void Start()
    {
        object1.SetActive(false);
    }
    public void Set()
    {
       object1.SetActive(true);
    }

}
