using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueControl : MonoBehaviour
{
    
    //Tipo Lógico
    //public bool logico, logicoNegado;
    
    //Acceso a los componentes
    //public MeshRenderer meshRenderer;
    
    //Tiempos en los fotogramas
    public float tiempoEntreFotogramas, fotogramasPorSegundo;
    
    // Start is called before the first frame update
    void Start()
    {
        //Tipo lógico
        //logico = true;

        // Componentes
        //meshRenderer.material.color = Color.green;

        //Otra forma de definir vector
        //transform.position = new Vector3(2, 0.5f, 0);

        //Otra forma de definir vector
        /*Vector3 nuevaPosicion = new Vector3(2, 0.5f, 0);
        transform.position = nuevaPosicion;*/

        //Una forma de definir un vector
        /*Vector3 nuevaPosicion;
        nuevaPosicion.x = 2;
        nuevaPosicion.y = 0.5f;
        nuevaPosicion.z = 0;

        transform.position = nuevaPosicion;*/

        //Variables de los objetos 3D
        /*print(transform.position);
        print(transform.rotation);
        print(transform.eulerAngles);
        print(transform.localScale);*/
    }

    // Update is called once per frame
    void Update()
    {
        //Tipo lógico
        //logicoNegado = !logico;

        //Tiempo en los fotogramas
        tiempoEntreFotogramas = Time.deltaTime;
        fotogramasPorSegundo = 1 / tiempoEntreFotogramas;
        // Mover objetos por tiempo
        transform.position += Vector3.right * Time.deltaTime;

        //Mover el objeto un metro a la derecha por fotograma
        //transform.position += Vector3.right;

        //transform.position += Vector3.right/100;
    }
}
