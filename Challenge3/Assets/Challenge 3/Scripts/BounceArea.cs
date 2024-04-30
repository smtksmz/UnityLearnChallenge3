using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceArea : MonoBehaviour
{
    private Rigidbody playerRb;

    private void Start()
    {
        playerRb = GameObject.Find("Player").GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerRb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        }
    }
}
