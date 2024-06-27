using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class Animal
{

    public string Name { get; protected set; }
    public int Identity { get; protected set; }


    public abstract void Speak();


    public virtual void Walk()
    {
        const int speed = 10;
        var text = Name + " is walking at speed " + speed;
        Debug.Log(text);
    }

}
