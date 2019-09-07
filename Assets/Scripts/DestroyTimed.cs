using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimed : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NewMethod();
    }
    private void NewMethod()
    {
        Destroy(this, t: 5); //5 is how many seconds you want before the object deletes itself
    }
}