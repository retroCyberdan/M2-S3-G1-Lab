using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5_3 : MonoBehaviour
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
        int minimo2 = TrovaMinimo2(array);
        Debug.Log("Di tutti i valori di questo Array, questi sono i 2 più piccoli --> " + minimo + " e " + minimo2);
        int massimo = TrovaMassimo(array);
        int massimo2 = TrovaMassimo2(array); 
        Debug.Log("Questi, invece, sono i 2 valori più alti --> " + massimo + " e " + massimo2);
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

    //Creo la funzione 'TrovaMinimo2'
    int TrovaMinimo2(int[] array)
    {
        int minimo2 = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimo2 && array[i] != TrovaMinimo(array))
            {
                minimo2 = array[i];
            }
        }
        return minimo2;


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

    //Creo la funzione 'TrovaMassimo2'
    int TrovaMassimo2(int[] array)
    {
        int massimo2 = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > massimo2 && array[i] != TrovaMassimo(array))
            {
                massimo2 = array[i];
            }
        }
        return massimo2;
    }
}
