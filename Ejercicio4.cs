using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        GameObject cilindro = GameObject.FindWithTag("Cylinder");
        GameObject cubo = GameObject.FindWithTag("Cube");
        float distancia = Vector3.Distance(cilindro.transform.position, cubo.transform.position);
        Debug.Log($"Distancia entre el cilindro y el cubo: {distancia}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
