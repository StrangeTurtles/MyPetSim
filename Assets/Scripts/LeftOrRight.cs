using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftOrRight : MonoBehaviour
{
    public PetStats pet;
    bool right = false;
    float statIncress;
    // Start is called before the first frame update
    void Start()
    {
        int randNum = Random.Range(0, 1);
        if(randNum == 0)
        {
            right = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Pick(bool guess)
    {
        if(guess = right)
        {
            Debug.Log("Right");
        }
        else
        {
            Debug.Log("Wrong");
        }
    }
}
