using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementrocket : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigidbodyRocket;
    Vector3 decoleRocket = new Vector3(0,3,0);
    Vector3 forceVectorSideway = new Vector3(2, 0, 0);
    Vector3 forceVectorSideway2 = new Vector3(1, 0, 0);
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
            rigidbodyRocket.AddRelativeForce(decoleRocket * Time.deltaTime * FORCE_MULTIPLIER * inputup);
        }
        float inputHorixontal = Input.GetAxis("Horizontal");
        if (inputHorixontal != 0)
        {
            rigidbodyRocket.AddForceAtPosition(forceVectorSideway, forceVectorSideway2);
        }
    }
}
