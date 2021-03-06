﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private Transform ultCheckpoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            Reaparecer();

    }
    public void Pasapor(Transform checkpoint)
    {
        ultCheckpoint = checkpoint;
    }

    public void Reaparecer()
    {
        GameManager.instance.SetCapsulasRest(GameManager.instance.GetCapsulasG() + 1); //Poner una cápsula de más poruq econ la sig línea se resta una
        GameManager.instance.SetGravedad(false);
        GameManager.instance.GetSegs();
        GameManager.instance.SetReapareceEnemigo(true);
        transform.position = ultCheckpoint.position;
    }
    public void ReinicioTotal()
    {
        GameManager.instance.SetCapsulasRest(GameManager.instance.GetCapsulasG() + 1); //Poner una cápsula de más poruq econ la sig línea se resta una
        GameManager.instance.SetGravedad(false);
        GameManager.instance.GetSegs();
        GameManager.instance.ReiniciaMonedas();
        GameManager.instance.SetReapareceEnemigo(true);
        GameManager.instance.AnulaMejoras();
    }
}
