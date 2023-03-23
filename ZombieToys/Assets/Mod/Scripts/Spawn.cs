using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    //Objeto que espawnea
    [SerializeField] private GameObject CuboejeZ, CuboEjeX, TRAIN, Firetruck, SpinningTop, mano, reloj, arches, robot, hearse, autoazul, baul,futbol,basket,botas,mesa,silla;
    [SerializeField] private GameObject Corazon, rayo;
    //Cantidad de objetos que spawnean
    [SerializeField] int numerOfItems, numeroDeTrenes, numeroDeBomberos, NumeroDeSpinningTop, NumeroDeManos, numeroDeReloj, numerodeArches, numerodeRobots, numerodeHearse,numerodesillas;
    [SerializeField] int numeroDeCorazones, numeroDeRayos;
    //No me acuerdo de que sirve
    [SerializeField] Transform parent;

    float RelojNumero;
    float ArchesNumero;




    void Start()
    {

        float BomberoNumero = NumeroBomberoZ();
        float TrenNumero = NumeroTrenX();
        int archesORobot = ArchesORobot();
        int relojobaul = RelojOBaul();
        int spinnigofutbolobasket = spinnnigOfutbolObasket();
        int bomberoohearseOautoAzul = BomberoOHearseOAutoAzul();
        int botaomanoomesa = BotaoManoomesa();


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
        if (bomberoohearseOautoAzul == 1)
        {
            for (int i = 0; i < numeroDeBomberos; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(0, 0, BomberoNumero);

                Instantiate(Firetruck, position, Quaternion.identity, parent);
            }
        }
        else if (bomberoohearseOautoAzul == 2)
        {
            for (int i = 0; i < numerodeHearse; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(0, 0, BomberoNumero);

                Instantiate(hearse, position, Quaternion.identity, parent);
            }
        }
        else if (bomberoohearseOautoAzul == 3)
        {
            for (int i = 0; i < numerodeHearse; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(0, 0, BomberoNumero);

                Instantiate(autoazul, position, Quaternion.identity, parent);
            }
        }

        //Spininng top, futnol o basket
        /////////////////////////////////////////////////////////////////////////
        if (spinnigofutbolobasket == 1)
        {
            for (int i = 0; i < NumeroDeSpinningTop; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(SpiningX(), 0, SpiningZ());

                Instantiate(SpinningTop, position, Quaternion.identity, parent);
            }
        }
        else if (spinnigofutbolobasket == 2)
        {
            for (int i = 0; i < NumeroDeSpinningTop; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(SpiningX(), 0, SpiningZ());

                Instantiate(futbol, position, Quaternion.identity, parent);
            }
        }
        else if (spinnigofutbolobasket == 3)
        {
            for (int i = 0; i < NumeroDeSpinningTop; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(SpiningX(), 0, SpiningZ());

                Instantiate(basket, position, Quaternion.identity, parent);
            }
        }
        ///////////////////////////////////////////////////////////////////////////
        //Mano, botas o mesa
        if (botaomanoomesa == 1)
        {
            for (int i = 0; i < NumeroDeManos; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(ManoX(), 0, ManoZ());

                Instantiate(botas, position, Quaternion.identity, parent);
            }
        }
        else if(botaomanoomesa == 2)
        {
            for (int i = 0; i < NumeroDeManos; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(ManoX(), 0, ManoZ());

                Instantiate(mano, position, Quaternion.identity, parent);
            }
        }
        else if(botaomanoomesa == 3)
        {
            for (int i = 0; i < NumeroDeManos; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(ManoX(), 0, ManoZ());

                Instantiate(mesa, position, Quaternion.identity, parent);
            }
        }
        /////////////////////////////////////////////////////////////////////////////////

        //Baul o reloj//////////////////////////////////////////////////////////////////
        if (relojobaul == 1)
        {
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
        }
        else
        {
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

                Instantiate(baul, position, Quaternion.identity, parent);
            }
        }
        ///////////////////////////////////////////////////////////////////////
        ///arches o robot//////////////////////////////////////////////////////
            if (archesORobot == 1)
            {
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
            else
            {
                for (int i = 0; i < numerodeRobots; i++)
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

                    Instantiate(robot, position, Quaternion.identity, parent);
                }
            }
            for (int i = 0; i < numerodesillas; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(SillaX(), 0, 0);

                Instantiate(silla, position, Quaternion.identity, parent);
            }

        ///////////////////////////////////////////////////////////////////
        ///Corazones y rayos
        for (int i = 0; i < numeroDeCorazones; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(CorazonX(), 0.5f, 0);

                Instantiate(Corazon, position, Quaternion.identity, parent);
            }
            for (int i = 0; i < numeroDeRayos; i++)
            {
                //Genera la posicion aleatoria con las funciones en amatillo
                Vector3 position = new Vector3(RayoX(), 0.5f, RayoZ());

                Instantiate(rayo, position, Quaternion.identity, parent);
            }




        }


        //Funciones que generan numeros aleatorios
        int GenerarNumeroX()
        {
            int[] NumeroX = new int[] { -20, -10, 10, 20 };
            int NumeroAleatorio = Random.Range(0, NumeroX.Length);
            return NumeroX[NumeroAleatorio];
        }
        int GenerarNumeroZ()
        {
            int[] NumeroX = new int[] { -15, 0, 15 };
            int NumeroAleatorio = Random.Range(0, NumeroX.Length);
            return NumeroX[NumeroAleatorio];
        }
        int GenerarNumeroZ2()
        {
            int[] NumeroX = new int[] { -10, 10, 20 };
            int NumeroAleatorio = Random.Range(0, NumeroX.Length);
            return NumeroX[NumeroAleatorio];
        }
        float NumeroTrenZ()
        {
            float[] possibleValues = { 15.5f, -15f };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }
        float NumeroTrenX()
        {
            float[] possibleValues = { -14.5f, 15.5f };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }

        float NumeroBomberoZ()
        {
            float[] possibleValues = { 14.5f, -15f };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }

        float SpiningZ()
        {
            float[] possibleValues = { -8, 0, 8 };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }
        float SpiningX()
        {
            float[] possibleValues = { 8.3f, -8.3f };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }
        float ManoX()
        {
            float[] possibleValues = { -25, 25 };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }
        float ManoZ()
        {
            float[] possibleValues = { 4, -4 };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }
        int ArchesORobot()
        {
            int[] NumeroX = new int[] { 1, 2 };
            int NumeroAleatorio = Random.Range(0, NumeroX.Length);
            return NumeroX[NumeroAleatorio];
        }
        int BomberoOHearseOAutoAzul()
        {
            int[] NumeroX = new int[] { 1, 2, 3 };
            int NumeroAleatorio = Random.Range(0, NumeroX.Length);
            return NumeroX[NumeroAleatorio];
        }
        float CorazonX()
        {
            float[] possibleValues = { -25f, -15f, 15f, 25f };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }
        float RayoX()
        {
            float[] possibleValues = { 5f, -5f };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }
        float RayoZ()
        {
            float[] possibleValues = { -14.5f, 14.5f };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }
        int RelojOBaul()
        {
            int[] NumeroX = new int[] { 1, 2 };
            int NumeroAleatorio = Random.Range(0, NumeroX.Length);
            return NumeroX[NumeroAleatorio];
        }
        
        int spinnnigOfutbolObasket()
        {
        int[] NumeroX = new int[] { 1, 2 };
        int NumeroAleatorio = Random.Range(0, NumeroX.Length);
        return NumeroX[NumeroAleatorio];
        }
        
        int BotaoManoomesa()
        {
            int[] NumeroX = new int[] { 1, 2,3 };
            int NumeroAleatorio = Random.Range(0, NumeroX.Length);
            return NumeroX[NumeroAleatorio];
        }
        float SillaX()
        {
            float[] possibleValues = { -30f,30f };
            float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
            return randomNumber;
        }



}
