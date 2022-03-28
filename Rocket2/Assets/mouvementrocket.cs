using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementrocket : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigidbodyRocket;
    Vector3 decoleRocket = new Vector3(0,3,0);
    const int FORCE_MULTIPLIER = 5500;
    void Start()
    {
        rigidbodyRocket = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputup = Input.GetAxis("Jump");
        if(inputup != 0)
        {
            rigidbodyRocket.AddForce(decoleRocket * Time.deltaTime * FORCE_MULTIPLIER * inputup);
        }
    }
}
