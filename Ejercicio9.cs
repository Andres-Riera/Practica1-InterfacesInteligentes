using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public float speed = 1f;
    GameObject esfera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        esfera = GameObject.FindWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        float xCubo = 0f;
        float yCubo = 0f;
        
        float xEsfera = 0f;
        float yEsfera = 0f;

        if (Input.GetKey(KeyCode.RightArrow)) xCubo += 1f;
        if (Input.GetKey(KeyCode.LeftArrow))  xCubo -= 1f;
        if (Input.GetKey(KeyCode.UpArrow))    yCubo += 1f;
        if (Input.GetKey(KeyCode.DownArrow))  yCubo -= 1f;

        if (Input.GetKey(KeyCode.D)) xEsfera += 1f;
        if (Input.GetKey(KeyCode.A)) xEsfera -= 1f;
        if (Input.GetKey(KeyCode.W)) yEsfera += 1f;
        if (Input.GetKey(KeyCode.S)) yEsfera -= 1f;

        transform.Translate(new Vector3(xCubo, yCubo, 0f) * speed);
        esfera.transform.Translate(new Vector3(xEsfera, yEsfera, 0f) * speed);

    }
}
