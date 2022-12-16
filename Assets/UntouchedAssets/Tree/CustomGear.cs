using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reaktion;

public class CustomGear : MonoBehaviour
{
    public ReaktorLink reaktor;
    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject tree4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float val = reaktor.Output;
        float colorval = reaktor.Output;
        tree1.transform.position = new Vector3(-21, val, -16);
        tree2.transform.position = new Vector3(16, val, -21);
        tree3.transform.position = new Vector3(16, val, 21);
        tree4.transform.position = new Vector3(-21, val, 16);

        

    }
}
