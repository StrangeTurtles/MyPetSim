using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saving : MonoBehaviour
{
    public SaveData saveData;
    public PetStats pet;
    string json;
    #region MonoBehaviour CallBacks
    // Start is called before the first frame update
    void Start()
    {
        loadFromJson();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startingSave(bool saveToJson)
    {
        saveData.savedHealth = pet.GetHealth();
        saveData.savedHunger = pet.GetHunger();
        saveData.savedHappiness = pet.GetHappiness();
        /*
        if(saveToJson)
        {
            savingToJson();
        }
        */
        savingToJson();
    }
   public void savingToJson()
    {
        json = JsonUtility.ToJson(saveData);
    }

    public void loadFromJson()
    {
        saveData = JsonUtility.FromJson<SaveData>(json);
        pet.SetHealth(saveData.savedHealth);
        pet.SetHunger(saveData.savedHunger);
        pet.SetHappiness(saveData.savedHappiness);
    }
    #endregion
}
