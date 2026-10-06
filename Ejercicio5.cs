using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public Vector3 desplazamientoCubo;
    public Vector3 desplazamientoEsfera;
    public Vector3 desplazamientoCilindro;
    
    GameObject cilindro;
    GameObject cubo;
    GameObject esfera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cilindro = GameObject.FindWithTag("Cylinder");
        cubo = GameObject.FindWithTag("Cube");
        esfera = GameObject.FindWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") > 0) {
            cilindro.transform.Translate(desplazamientoCilindro);
            cubo.transform.Translate(desplazamientoCubo);
            esfera.transform.Translate(desplazamientoEsfera);
        }
    }
}
