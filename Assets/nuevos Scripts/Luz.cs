using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{

    public GameObject luz1;
    public GameObject luz2;
    public GameObject interructor;


    public bool Encendido;
    public bool EncenderLuz;

    
    // Start is called before the first frame update
    void Start()
    {

        luz1.gameObject.SetActive(false);
        luz2.gameObject.SetActive(false);
      

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && Encendido == false && EncenderLuz == true)
        {
            luz1.gameObject.SetActive(true);
            luz2.gameObject.SetActive(true);

            Encendido = true;
        }

        else if (Input.GetKeyDown(KeyCode.E) && Encendido == true && EncenderLuz == true)
        {
            luz1.gameObject.SetActive(false);
            luz2.gameObject.SetActive(false);

            Encendido = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        EncenderLuz = true;
    }

    private void OnTriggerExit(Collider other)
    {
        EncenderLuz = false;
    }

}
