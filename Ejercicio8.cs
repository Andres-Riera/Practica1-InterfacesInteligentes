using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1.0f, 0.0f, 0.0f);
    public float speed = 1.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 posInicial = transform.position;
        posInicial.y = 1f;
        transform.position = posInicial;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desplazamiento = moveDirection * speed * Time.deltaTime;
        // transform.Translate(desplazamiento);
        // e
        transform.Translate(desplazamiento, Space.World);
    }
}
