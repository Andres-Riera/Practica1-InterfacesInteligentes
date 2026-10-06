using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidad;
    void Start()
    {
        velocidad = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * velocidad;
        float rotation = Input.GetAxis("Horizontal") * velocidad;
        string mensaje1 = "Se ha pulsado flecha ";
        if (Input.GetAxis("Vertical") != 0)
        {
            if (Input.GetAxis("Vertical") < 0)
            {
                mensaje1 += "abajo";
            } else
            {
                mensaje1 += "arriba";
            }
            Debug.Log($"{mensaje1} {translation}");
        }
        string mensaje2 = "Se ha pulsado flecha ";
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                mensaje2 += "izquierda";
            } else
            {
                mensaje2 += "derecha";
            }
            Debug.Log($"{mensaje2} {rotation}");
        }
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, translation, 0);
        transform.Translate(rotation, 0, 0);
    }
}
