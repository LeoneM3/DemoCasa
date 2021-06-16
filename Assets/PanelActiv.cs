using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActiv : MonoBehaviour
{
    public GameObject Text;
    public GameObject Trigger;


    public bool Mostrando;
    public bool MostrarInfo;


    // Start is called before the first frame update
    void Start()
    {

        Text.gameObject.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.I) && Mostrando == false && MostrarInfo == true)
        {
            Text.gameObject.SetActive(true);

            Mostrando = true;
        }

        else if (Input.GetKeyDown(KeyCode.I) && Mostrando == true && MostrarInfo == true)
        {
            Text.gameObject.SetActive(false);

            Mostrando = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        MostrarInfo = true;
    }

    private void OnTriggerExit(Collider other)
    {
        MostrarInfo = false;
    }
}
