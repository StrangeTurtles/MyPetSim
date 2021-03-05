using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetStats : MonoBehaviour
{
    #region Public Fields
    public float healthDepletion = .1f;
    public float hungerDepletion = .1f;
    public float happinessDepletion = .1f;
    public float timerLength = 10f;
    #endregion
    #region Private Fields
    private float Health = 100f;
    private float Hunger = 100f;
    private float Happiness = 100f;
    private float timer;
    #endregion
    #region MonoBehaviour Callbacks
    // Start is called before the first frame update
    void Start()
    {
        timer = timerLength;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health > 100f)
        {
            Health = 100f;
        }
        if (Hunger > 100f)
        {
            Hunger = 100f;
        }
        if (Happiness > 100f)
        {
            Happiness = 100f;
        }
        #region Timer
        if (timer <= 0f)
        {
            Health -= healthDepletion;
            Hunger -= hungerDepletion;
            Happiness -= happinessDepletion;
            timer = timerLength;
        }
        else
        {
            timer -= Time.deltaTime;
        }
        #endregion

        //Debug.Log($"Health: {Health}");
        //Debug.Log($"Hunger: {Hunger}");
        //Debug.Log($"Happiness: {Happiness}");
    }

    #endregion
    #region Returns
    public float GetHealth()
    {
        return Health;
    }
    public float GetHunger()
    {
        return Hunger;
    }
    public float GetHappiness()
    {
        return Happiness;
    }
    #endregion
    #region Change Varables
    public void ChangeHealth(float Change)
    {
        Health += Change;
    }
    public void ChangeHunger(float change)
    {
        Hunger += change;
    }
    public void ChangeHappiness(float change)
    {
        Happiness += change;
    }
    #endregion
    #region Set Varables
    public void SetHealth(float change)
    {
        Health = change;
    }
    public void SetHunger(float change)
    {
        Hunger = change;
    }
    public void SetHappiness(float change)
    {
        Happiness = change;
    }
    #endregion
}
