using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public GameObject[] flechas;
    private float TiempoEnemigos;
    public float TiempoInicio;
   // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        if (TiempoEnemigos <= 0)
        {
            int random= Random.Range(0, flechas.Length);
            Instantiate(flechas[random], transform.position, Quaternion.identity);

            TiempoEnemigos = TiempoInicio;
        }
        else
        {
            TiempoEnemigos-=Time.deltaTime;
        }
    }
}
