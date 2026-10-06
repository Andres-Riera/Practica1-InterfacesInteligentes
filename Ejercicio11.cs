using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    GameObject esfera;
    public float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        esfera = GameObject.FindWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = esfera.transform.position - transform.position;
        direccion.y = 0f;
        Vector3 direccionNormalizada = direccion.normalized;
        transform.Translate(direccionNormalizada * speed * Time.deltaTime, Space.World);
    }
}
