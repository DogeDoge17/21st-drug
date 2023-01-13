using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(rb.gameObject.transform.forward * 10 * Time.deltaTime, ForceMode.Impulse);

        }
    }

    public void wPressed()
    {

    }
}
