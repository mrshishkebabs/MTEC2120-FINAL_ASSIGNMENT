using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidcontrol : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Vector2.left;
        Vector3 vel = dir * speed * Time.deltaTime;
        transform.Translate(new Vector3(10, -2, 0) * Time.deltaTime);
        Destroy(gameObject, 3.0f);
    }
}
