using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidad = 1f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * 5f;
        rotation *= Time.deltaTime;
        transform.Rotate(0, rotation, 0);
        transform.Translate(transform.forward * Time.deltaTime * velocidad);
        Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
    }
}
