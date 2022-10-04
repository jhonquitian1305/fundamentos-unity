using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueControl : MonoBehaviour
{
    //For
    public int[] arregloDeEnteros;
    public int repeticiones;
    
    //Arreglo de datos
    //public int[] arregloDeEnteros;
    
    //Operaciones lógicas
    /*public bool valorA, valorB, and, or;*/
    
    
    //Condición if-else
    /*public bool activado;
    public MeshRenderer meshRenderer;
    public int valor;*/
    
    
    //Operaciones relacionales
    /*public int num1, num2;
    public bool igual, distinto, mayor, menor, mayorIgual, menorIgual;*/
    
    //Tipo Lógico
    //public bool logico, logicoNegado;
    
    //Acceso a los componentes
    //public MeshRenderer meshRenderer;
    
    //Tiempos en los fotogramas
    //public float tiempoEntreFotogramas, fotogramasPorSegundo;
    
    // Start is called before the first frame update
    void Start()
    {
        //For
        for (int i = 0; i < arregloDeEnteros.Length; i++)
        {
            arregloDeEnteros[i] *= 10;
        }
        
        //Arreglo de datos
        /*arregloDeEnteros[0] = 15;
        print(arregloDeEnteros[2]);*/
        
        //for-each
        /*int contador = 0;
        foreach (int numero in arregloDeEnteros)
        {
            arregloDeEnteros[contador] *= 10;
            contador++;
        }*/

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
        //Operaciones lógicas
        /*and = valorA && valorB;
        or = valorA || valorB;*/

        //Condición if-else
        /*if (activado)
        {
            meshRenderer.material.color = Color.green;
        }
        else
        {
            meshRenderer.material.color = Color.red;
        }*/

        //Condición si anidado
        /*if (valor > 5)
        {
            meshRenderer.material.color = Color.green;
        }
        else if(valor < -5)
        {
            meshRenderer.material.color = Color.red;
        }
        else
        {
            meshRenderer.material.color = Color.yellow;
        }*/

        //Operaciones relacionales
        /*igual = num1 == num2;
        distinto = num1 != num2;
        mayor = num1 > num2;
        menor = num1 < num2;
        mayorIgual = num1 >= num2;
        menorIgual = num1 <= num2;*/

        //Tipo lógico
        //logicoNegado = !logico;

        //Tiempo en los fotogramas
        //tiempoEntreFotogramas = Time.deltaTime;
        //fotogramasPorSegundo = 1 / tiempoEntreFotogramas;
        // Mover objetos por tiempo
        //transform.position += Vector3.right * Time.deltaTime;

        //Mover el objeto un metro a la derecha por fotograma
        //transform.position += Vector3.right;

        //transform.position += Vector3.right/100;
    }
}
