using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public int frames;
    Color color;
    public int framesUpdate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frames = 0;
        framesUpdate = 120;
        color = new Color(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        if (frames % framesUpdate == 0)
        {
            float random = Random.value;
            if (random < 0.33f)
            {
                color.r = Random.value;
            }
            else if (random < 0.66f)
            {
                color.g = Random.value;
            }
            else
            {
                color.b = Random.value;
            }
            GetComponent<Renderer>().material.color = color;
        }
    }
}
