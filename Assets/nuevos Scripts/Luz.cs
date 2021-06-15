using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{

    public GameObject luz1;
    public GameObject luz2;
    public GameObject interructor;

    public bool isTrigger;

    
    // Start is called before the first frame update
    void Start()
    {

        luz1.gameObject.SetActive(false);
        luz2.gameObject.SetActive(false);
      

    }

    // Update is called once per frame
    void Update()
    {
       if (isTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E)){
                luz1.gameObject.SetActive(true);
                luz2.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                luz1.gameObject.SetActive(false);
                luz2.gameObject.SetActive(false);

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isTrigger = false;
    }

}
