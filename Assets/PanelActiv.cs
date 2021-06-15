using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActiv : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Text;
    public GameObject Trigger;


    public bool Mostrando;
    public bool MostrarInfo;


    // Start is called before the first frame update
    void Start()
    {

        Panel.gameObject.SetActive(false);
        Text.gameObject.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && Mostrando == false && MostrarInfo == true)
        {
            Panel.gameObject.SetActive(true);
            Text.gameObject.SetActive(true);

            Mostrando = true;
        }

        else if (Input.GetKeyDown(KeyCode.E) && Mostrando == true && MostrarInfo == true)
        {
            Panel.gameObject.SetActive(false);
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
