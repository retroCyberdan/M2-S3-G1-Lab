using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab5_1 : MonoBehaviour
{
    //Creo 3 variabili intere esposte
    public int numero;
    public int numeroDiBase;
    public int numeroMultiplo;

    // Start is called before the first frame update
    void Start()
    {
        if (IsEven(numero) == true)
        {
            Debug.Log("Il numero " + numero + " è pari");
        }
        else
        {
            Debug.Log("Il numero " + numero + " è dispari");
        }
        if (IsMultipleOf(numeroDiBase, numeroMultiplo) == true)
        {
            Debug.Log("Il numero " + numeroMultiplo + " è multiplo del numero " + numeroDiBase);
        }
        else
        {
            Debug.Log("Il numero " + numeroMultiplo + " NON è multiplo del numero " + numeroDiBase);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creo la fnzione 'IsEven'
    bool IsEven(int number)
    {
        if (number % 2 == 0)//controllo se il modulo del numero mi da zero
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //Creo la fnzione 'IsMultipleOf'
    bool IsMultipleOf(int basE, int multiple)
    {
        if (multiple % basE == 0)//controllo se il modulo di 'multiple' mi da zero
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
