using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    Vector2 inputMov;
    Vector2 inputRot;
    public float velCamina = 10f;
    public float SenM = 1f;
    Transform Cam;
    float rotX;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cam = transform.GetChild(0);
        rotX = Cam.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        //controles
        inputMov.x = Input.GetAxis("Horizontal");
        inputMov.y = Input.GetAxis("Vertical");

        //camara
        inputRot.x = Input.GetAxis("Mouse X") * SenM;
        inputRot.y = Input.GetAxis("Mouse Y") * SenM;
    }

    private void FixedUpdate()
    {
        float vel = velCamina;
        rb.velocity =
            transform.forward * vel * inputMov.y
            + transform.right * vel * inputMov.x
            ;



        //cambiar position con rotacion

        transform.rotation *= Quaternion.Euler(0, inputRot.x , 0);

        //mirar arriba y abajo

        rotX -= inputRot.y;
        rotX = Mathf.Clamp(rotX, -50, 50);
        Cam.localRotation = Quaternion.Euler(rotX, 0, 0);
    }
} 
 
