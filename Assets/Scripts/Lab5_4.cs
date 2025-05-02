using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5_4 : MonoBehaviour
{
    //dichiaro delle variabili intere esposte
    public int dimensioneInizialeArray;
    public int rangeMin;
    public int rangeMax;
    //public int nuovaDimensione; <--- abilitarla per usare la prima versione dello Script
    
    // Start is called before the first frame update
    void Start()
    {
        //Questa prima versione permette all'utente di decidere la grandezza del nuovo Array da creare
        //
        //
        //
        //int[] array = GeneraArray(dimensioneArray, rangeMin, rangeMax);
        //Debug.Log("Il tuo Array ha i seguenti valori:");
        //StampaArray(array);
        //Debug.Log("Come ben sai, non è possibile cambiare la dimensione di un Array una volta creato, ma io ci proverò comunque, basandomi sulla nuova dimensione che hai scelto...");
        //int[] nuovoArray = CambiaDimensioneArray(array, nuovaDimensione);
        //StampaArray(nuovoArray);
        //Debug.Log("Ecco, vedi! Ci sono riuscito!");
        //
        //
        //
        //Questa, invece, rispecchia quello richiesto dalla traccia
        int[] array = GeneraArray(dimensioneInizialeArray, rangeMin, rangeMax);
        Debug.Log("Questi sono gli elementi dell'Array originale della dimensione che hai scelto:");
        StampaArray(array);
        Debug.Log("Come ben sai, non è possibile cambiare la dimensione di un Array una volta creato, ma essendo un TEMIBILE PIRATA ci proverò comunque...");
        int[] arrayPiccolo = CambiaDimensioneArray(array, dimensioneInizialeArray - 3);
        StampaArray(arrayPiccolo);
        Debug.Log("Accidenti! Sono riuscito a rimpicciolire l'Array togliendo 3 elementi!");
        Debug.Log("Mmm... chissà se riesco anche ad ingrandirlo...");
        int[] arrayGrande = CambiaDimensioneArray(array, dimensioneInizialeArray + 15);
        StampaArray(arrayGrande);
        Debug.Log("Accidenti, ci sono riuscito! Ho aggiunto ben 15 elementi! (Anche se sono tutti zeri...)");
        Debug.Log("..."); 
        Debug.Log("Ora che ci penso... meglio mettere tutto com'era, prima che Elaine se ne accorga!");
        StampaArray(array);
        Debug.Log("Perfetto!");
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

    ////Creo la funzione'StampaArray'
    //void StampaArray(int[] array)
    //{
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        Debug.Log(array[i]);
    //    }
    //}

    //Creo la funzione'StampaArray' usando una variabile di tipo 'string', per provare a cambiare
    void StampaArray(int[] array)
    {
        string stampa = "";
        for (int i = 0; i < array.Length; i++)
        {
            stampa += array[i] + " ";
        }
        Debug.Log(stampa);
    }

    //Creo la funzione 'CambiaDimensioneArray'
    int[] CambiaDimensioneArray(int[] array, int dim)
    {
        int[] nuovoArray = new int[dim];
        if (dim < array.Length)
        {
            for (int i = 0; i < dim; i++)
            {
                nuovoArray[i] = array[i];
            }
            return nuovoArray;
        }
        else if (dim > array.Length)
        {
            for (int i = 0; i < array.Length; i++)
            {
                nuovoArray[i] = array[i];
            }
            return nuovoArray;
        }
        else
        {
            return array;
        }
    }
}