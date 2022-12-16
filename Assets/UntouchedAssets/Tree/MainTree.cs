using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class MainTree : MonoBehaviour
{

    public GameObject leaf;
    public float projectileForce = 1000f;

    private void Start()
    {
        //Physics.sleepAngularVelocity = 0.1f;
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        GameObject go = Instantiate(leaf);
        go.GetComponent<Rigidbody>().AddForce(transform.forward);

    }
}
