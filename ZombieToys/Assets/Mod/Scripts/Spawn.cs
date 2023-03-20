using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    //Objeto que espawnea
    [SerializeField] private GameObject CuboejeZ,CuboEjeX,TRAIN,Firetruck, SpinningTop,mano,reloj,arches;
    //Cantidad de objetos que spawnean
    [SerializeField] int numerOfItems,numeroDeTrenes,numeroDeBomberos, NumeroDeSpinningTop,NumeroDeManos,numeroDeReloj,numerodeArches;
    //No me acuerdo de que sirve
    [SerializeField] Transform parent;

    public float RelojNumero;
    public float ArchesNumero;




    void Start()
    {
        float BomberoNumero = NumeroBomberoZ();
        float TrenNumero = NumeroTrenX();
        //Genera los obstaculos horizontales
        for (int i = 0; i < numerOfItems; i++)
        {
            //Genera la posicion aleatoria con las funciones en amatillo
            Vector3 position = new Vector3(GenerarNumeroZ2(), 0, GenerarNumeroX());

            Instantiate(CuboejeZ, position, Quaternion.identity, parent);
        }
        //Genera los obstaculos verticales
        for (int i = 0; i < numerOfItems; i++)
        {
            //Genera la posicion aleatoria con las funciones en amatillo
            Vector3 position = new Vector3(GenerarNumeroX(), 0, GenerarNumeroZ());

            Instantiate(CuboEjeX, position, Quaternion.identity, parent);
        }
        //TREN
        for (int i = 0; i < numeroDeTrenes; i++)
        {
            //Genera la posicion aleatoria con las funciones en amatillo
            Vector3 position = new Vector3(TrenNumero, 0, NumeroTrenZ());

            Instantiate(TRAIN, position, Quaternion.identity, parent);
        }
        //BOMBERO
        for (int i = 0; i < numeroDeBomberos; i++)
        {
            //Genera la posicion aleatoria con las funciones en amatillo
            Vector3 position = new Vector3(0, 0, BomberoNumero);

            Instantiate(Firetruck, position, Quaternion.identity, parent);
        }
        //Spininng top
        for (int i = 0; i < NumeroDeSpinningTop; i++)
        {
            //Genera la posicion aleatoria con las funciones en amatillo
            Vector3 position = new Vector3(SpiningX(), 0, SpiningZ());

            Instantiate(SpinningTop, position, Quaternion.identity, parent);
        }
        //Mano
        for (int i = 0; i < NumeroDeSpinningTop; i++)
        {
            //Genera la posicion aleatoria con las funciones en amatillo
            Vector3 position = new Vector3(ManoX(), 0, ManoZ());

            Instantiate(mano, position, Quaternion.identity, parent);
        }
        for (int i = 0; i < numeroDeReloj; i++)
        {

            if (BomberoNumero > 0)
            {
                RelojNumero = -15f;
            }
            else if (BomberoNumero < 0)
            {
                RelojNumero = 14.5f;
            }
            //Genera la posicion aleatoria con las funciones en amatillo
            Vector3 position = new Vector3(0, 0, RelojNumero);

            Instantiate(reloj, position, Quaternion.identity, parent);
        }
        for (int i = 0; i < NumeroDeSpinningTop; i++)
        {
            //Genera la posicion aleatoria con las funciones en amatillo
            Vector3 position = new Vector3(ManoX(), 0, ManoZ());

            Instantiate(mano, position, Quaternion.identity, parent);
        }
        for (int i = 0; i < numerodeArches; i++)
        {

            if (TrenNumero > 0)
            {
                ArchesNumero = -14.5f;
            }
            else if (TrenNumero < 0)
            {
                ArchesNumero = 15.5f;
            }
            //Genera la posicion aleatoria con las funciones en amatillo
            Vector3 position = new Vector3(ArchesNumero, 0, -15);

            Instantiate(arches, position, Quaternion.identity, parent);
        }
    }


    //Funciones que generan numeros aleatorios
    public int GenerarNumeroX()
    {
        int[] NumeroX = new int[] {-20,-10,10, 20 };
        int NumeroAleatorio = Random.Range(0, NumeroX.Length);
        return NumeroX[NumeroAleatorio];
    }
    public int GenerarNumeroZ()
    {
        int[] NumeroX = new int[] { -15,0,15 };
        int NumeroAleatorio = Random.Range(0, NumeroX.Length);
        return NumeroX[NumeroAleatorio];
    }
    public int GenerarNumeroZ2()
    {
        int[] NumeroX = new int[] {-10, 10, 20 };
        int NumeroAleatorio = Random.Range(0, NumeroX.Length);
        return NumeroX[NumeroAleatorio];
    }
    public float NumeroTrenZ()
    {
        float[] possibleValues = {15.5f, -15f };
        float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
        return randomNumber;
    }
    public float NumeroTrenX()
    {
        float[] possibleValues = { -14.5f, 15.5f };
        float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
        return randomNumber;
    }

    public float NumeroBomberoZ()
    {
        float[] possibleValues = { 14.5f, -15f };
        float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
        return randomNumber;
    }

    public float SpiningZ()
    {
        float[] possibleValues = { -8,0,8};
        float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
        return randomNumber;
    }
    public float SpiningX()
    {
        float[] possibleValues = { 8.3f,-8.3f };
        float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
        return randomNumber;
    }
    public float ManoX()
    {
        float[] possibleValues = { -25,25};
        float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
        return randomNumber;
    }
    public float ManoZ()
    {
        float[] possibleValues = { 4,-4 };
        float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
        return randomNumber;
    }




}
