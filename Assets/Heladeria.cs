using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour {

    /*
     Heladería "Los tres gustos"

    Esta heladería ofrece 3 gustos: chocolate, frutilla y dulce de leche y toma pedidos mediante códigos. 
    El cliente debe pedir los gustos ingresando CHO, FRU y DDL. Además debe ingresar una cantidad de helado en gramos (250 para un cuarto, 500 para medio k, etc). 
    Esta semana tiene una promoción con frutilla, por lo que el precio se reduce un %10 solo en ese gusto.

    . Mostrar un mensaje de error y ningún otro mensaje ni realizar ningún cálculo si no se ingresa un código válido o si las cantidades de helado son menores a 250 o mayores que 3000. 

    . Sabiendo que el kilo de helado sale $500, devolver el costo del pedido si los ingresos son válidos. Recuerdo contemplar la promoción.
         */
    public string cod;
    public int Cant_Gramos;
    int precioK = 500;
    int total;

    // Use this for initialization
    void Start () {
		if (Cant_Gramos < 250 || 3000 < Cant_Gramos)
        {
            Debug.Log("Cantidad no permitida");
        }
        else
        {
            switch (cod)
            {
                case "CHO":
                    total = Cant_Gramos * precioK / 1000;
                    Debug.Log("En total va a salir $" + total);
                    break;

                case "FRU":
                    total = Cant_Gramos * precioK / 1000 * 90 / 100;
                    Debug.Log("En total va a salir $" + total);
                    break;

                case "DDL":
                    total = Cant_Gramos * precioK / 1000;
                    Debug.Log("En total va a salir $" + total);
                    break;

                default:
                    Debug.Log("El codigo no es un codigo permitido");
                    break;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
