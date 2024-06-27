using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public override void Speak()
    {
        var text = "My name is" + Name;
        var text2 = "My identity is " + Identity;
        const string text3 = "And i am a Dot";

        Debug.Log(text);
        Debug.Log(text2);
        Debug.Log(text3);    
    }

    public override void Walk()
    {
        const int speed = 15;
        var text = Name + " is walking at speed " + speed;
        Debug.Log(text);    }

    private void Start()
    {
        Name = "Dog";
        Identity = 654321;
    }

    private void Update()
    {
        
    }
}
