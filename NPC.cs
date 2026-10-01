using UnityEngine;

public class NPC : MonoBehaviour
{
    public int level = 1;
    public float speed = 1.2f;
    public int health = 100;

    void Start()
    {
        // Suma el nivel al valor de la salud al inicio del juego
        health += level;
        
        // Muestra el valor actualizado de health en la consola
        Debug.Log(health);
    }

    void Update()
    {
        Vector3 newPosicion = transform.position;
        newPosicion.z += speed * Time.deltaTime;

        transform.position = newPosicion;
    }
} // <-- Esta llave del final cierra la clase NPC y debe ser la ÚLTIMA línea del archivo