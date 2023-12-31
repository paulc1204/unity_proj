using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength; 

    // Start is called before the first frame update
    void Start()
    {
        transform.SetPositionAndRotation(new Vector3(-15, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
}
