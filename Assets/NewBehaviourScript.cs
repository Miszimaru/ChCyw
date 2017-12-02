using UnityEngine;
using System.Collections;

public class ruch : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float szybkosc = Time.deltaTime * 15; // szybkosc poruszania
        if (Input.GetKey("up"))
            transform.Translate(0, 0, szybkosc); //poruszanie sie do pszodu
        if (Input.GetKey("down"))
            transform.Translate(0, 0, -szybkosc); //poruszanie sie do tylu
        if (Input.GetKey("left"))
            transform.Translate(-szybkosc, 0, 0); //poruszanie sie w lewo
        if (Input.GetKey("right"))
            transform.Translate(szybkosc, 0, 0); //poruszanie sie w prawo

    }

}
