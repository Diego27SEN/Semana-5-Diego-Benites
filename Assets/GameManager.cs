using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int variable;

    Slime Slimea = new Slime(10);
    Slime Slimeb = new Slime(20);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Slime Slimec = Slimea + Slimeb;
            print("Slime C life: " + Slimec.life);
        }
    }




}
