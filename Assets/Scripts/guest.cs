using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class guest : MonoBehaviour
{

    private double fun;
    private double energy;

    private double hunger;
    private double thirst;

    private enum wet
    {
        dry,
        damp,
        soaked
    }

    private enum drunk
    {
        sober,
        tipsy,
        wasted
    }

    private enum sick
    {
        healthy,
        bad,
        worse
    }

    private enum rides
    {
        coaster,
        vomit,
        kiddie,
        dark,
        edu,
        water
    }

    private int[] prefs;

    private drunk d;
    private wet w;
    private sick s;

    private int steps;


    
    // Start is called before the first frame update
    void Start()
    {
        fun = 40;
        energy = 80;

        hunger = 60;
        thirst = 60;

        int[] prefs = {
            Random.Range(1,6),
            Random.Range(1,6),
            Random.Range(1,6),
            Random.Range(1,6),
            Random.Range(1,6),
            Random.Range(1,6)
        };

        steps = 0;
        w = wet.dry;
        d = drunk.sober;
        s = sick.healthy;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //runs once per in game second
    void perSecond()
    {
        if (steps > 10)
        {
            steps = 0;
            energy--;
        }

        fun -= .16; //drops 1 point per minute
        hunger -= .16; 
        thirst -= .32; //drops 2 points per minute

    }

    public void eat(int f){
        hunger += f;
    }

    public void drink(int d){
        thirst += d;
    }

    public void drink(int d, int alc)
    {
        thirst += d;
        //drunk needs underlying stats
    }

    public void doRide(ride r)
    {
        fun += prefs[r.type] * 2;
    }
}
