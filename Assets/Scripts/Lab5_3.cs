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
        Debug.Log("Di tutti i valori di questo Array, questi sono i 2 più piccoli:");
        //int minimo = TrovaMinimo(array);
        //Debug.Log(minimo);
        TrovaMinimi2(array);
        Debug.Log("Questi, invece, sono i 2 valori più alti:");
        //int massimo = TrovaMassimo(array);
        //Debug.Log(massimo);
        TrovaMassimi2(array);       
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
    void TrovaMinimi2(int[] array)
    {
        int minimo2 = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minimo2 && array[i] != TrovaMinimo(array))
            {
                minimo2 = array[i];
            }
        }
        Debug.Log(TrovaMinimo(array));
        Debug.Log(minimo2);
        return;


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
    void TrovaMassimi2(int[] array)
    {
        int massimo2 = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > massimo2 && array[i] != TrovaMassimo(array))
            {
                massimo2 = array[i];
            }
        }
        Debug.Log(TrovaMassimo(array));
        Debug.Log(massimo2);
        return;
    }
}
