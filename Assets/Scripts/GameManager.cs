using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var cat = new Cat();
        cat.Speak();
        cat.Walk();

        var dog = new Dog();
        dog.Speak();
        dog.Walk();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
