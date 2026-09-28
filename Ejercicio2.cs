using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public Vector3 vector1;
    public Vector3 vector2;

    public float magnitudVector1;
    public float magnitudVector2;
    public float angulo;
    public float distancia;
    public string comparacionAltura;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // magnitudes
        magnitudVector1 = vector1.magnitude;
        magnitudVector2 = vector2.magnitude;
        Debug.Log($"Magnitud Vector 1: {magnitudVector1}");
        Debug.Log($"Magnitud Vector 2: {magnitudVector2}");
        // ángulo
        angulo = Vector3.Angle(vector1, vector2);
        Debug.Log($"Ángulo que forman: {angulo}");
        // distancia
        distancia = Vector3.Distance(vector1, vector2);
        Debug.Log($"Distancia entre vectores: {distancia}");
        // altura
        if (Mathf.Approximately(vector1.y, vector2.y)) {
            comparacionAltura = "Ambos vectores están a la misma altura.";
        }
        else if (vector1.y > vector2.y) {
            comparacionAltura = "El Vector 1 está a una altura mayor.";
        } else {
            comparacionAltura = "El Vector 2 está a una altura mayor.";
        }
        Debug.Log(comparacionAltura);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
