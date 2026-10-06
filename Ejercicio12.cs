using UnityEngine;

public class Ejercicio12 : MonoBehaviour
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
        direccion.y = transform.position.y;
        transform.LookAt(direccion);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
