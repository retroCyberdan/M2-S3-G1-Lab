using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Lab5_2 : MonoBehaviour
{
    //dichiaro delle variabili intere esposte
    public int dimensioneArray;
    public int rangeMin;
    public int rangeMax;
    
    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneraArray(dimensioneArray, rangeMin, rangeMax);
        Debug.Log("Ecco tutti i valori presenti nel tuo Array:");
        StampaArray(array);
        int minimo = TrovaMinimo(array);
        Debug.Log("Di tutti i valori di questo Array, questo è il più piccolo --> " + minimo);
        int massimo = TrovaMassimo(array);
        Debug.Log("Questo, invece, è il valore più alto --> " + massimo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creo la funzione 'GeneraArray'
    int[] GeneraArray(int dimensione, int min, int max)
    {
        int[] array = new int[dimensione];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(min, max + 1);//min inclusivo, max esclusivo
        }
        return array;
    }

    //Creo la funzione'StampaArray'
    void StampaArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    //Creo la funzione 'TrovaMinimo'
    int TrovaMinimo(int[] array)
    {
        int minimo = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minimo)
            {
                minimo = array[i];
            }
        }
        return minimo;
    }

    //Creo la funzione 'TrovaMassimo'
    int TrovaMassimo(int[] array)
    {
        int massimo = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > massimo)
            {
                massimo = array[i];
            }
        }
        return massimo;
    }
}
