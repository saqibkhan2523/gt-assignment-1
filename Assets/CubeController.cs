using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public bool isGameStarted = false;

    public float countdown = 0;

    public float totalGameTime = 10f;

    public float rotationSpeed;

    public float scaleSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        countdown = totalGameTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameStarted)
        {

            if (countdown >= 0)
            {
                countdown -= Time.deltaTime;

                //Rotation.
                float rightRotation = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
                float leftRotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

                transform.Rotate(Vector3.forward, Time.deltaTime * rightRotation);
                transform.Rotate(Vector3.back, Time.deltaTime * leftRotation);

                // Scale
                if (Input.GetKey(KeyCode.Space))
                {
                    transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
                }
                else
                {
                    if (transform.localScale.x >= 1f)
                    {
                        transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
                    }
                }
            }
        }
    }
}
