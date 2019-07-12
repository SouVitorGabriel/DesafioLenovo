using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    [SerializeField]
    private GameObject redoma;

    public float velocidade = 5f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float h = velocidade * Input.GetAxis("Mouse X");
            float v = velocidade * Input.GetAxis("Mouse Y");

            if (redoma.transform.eulerAngles.z + v <= 0.1f || redoma.transform.eulerAngles.z + v >= 179.9f)
                v = 0;

            redoma.transform.eulerAngles = new Vector3(redoma.transform.eulerAngles.x, redoma.transform.eulerAngles.y + h, redoma.transform.eulerAngles.z + v);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll != 0)
        {
            redoma.transform.localScale = redoma.transform.localScale * (1f - scroll);
        }

    }
}
