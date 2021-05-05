using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaFlecha : MonoBehaviour
{
    public float velocidad;
    public bool adentro = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position+=transform.right*-velocidad*Time.deltaTime;
       if (true)
       {
           adentro = true;
       } 
       else
       {
           adentro = false;
       }

       if(Input.GetKey("right"))
       {
           if (adentro)
           {
               GameObject.Find("Cuadrado").GetComponent<Logicajugador>();
               Destroy(gameObject);
           }
       }

       void OnTriggerEnter2D(Collider2D collision) 
       {
         if (collision.gameObject.tag == "Player");  
       }
    }
}
