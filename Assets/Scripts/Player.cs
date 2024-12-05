using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed, speedRot;

    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * Input.GetAxis("Vertical") * speed +
                                             transform.right * Input.GetAxis("Horizontal") * speed;
                                             
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * speedRot);

        GetComponent<Animator>().SetFloat("velocity", GetComponent<Rigidbody>().velocity.magnitude);
    }
}
