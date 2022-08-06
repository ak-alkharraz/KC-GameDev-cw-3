using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    string heroname = "water";
    int heropower = 100;
    string villianname = "cola";
    int villianpower = 99;
    float playerspeed = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villianpower)
        {
            print(heroname + " is stronger");
        }
        else if (heropower < villianpower)
        {
            print(villianname + " is stronger");
        }
        else
        {
            print(villianname + " and " + heroname + " are equal");
        }

        setspeed(2.5f);
    }
    void setspeed(float speed)
    {
        print("i used to have a speed of " + playerspeed);
        playerspeed = speed;
        print("but after my training my new speed is " + playerspeed);
    }
}
