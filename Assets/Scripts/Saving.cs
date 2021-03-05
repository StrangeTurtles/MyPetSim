using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class Saving : MonoBehaviour
{
    public PetStats pet;
    string json;
    string path;
    #region MonoBehaviour CallBacks
    // Start is called before the first frame update
    void Start()
    {
        path = $"{Application.persistentDataPath}";
        loadFromJson();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startingSave(bool saveToJson)
    {
        SaveData saveData = new SaveData();
        saveData.savedHealth = pet.GetHealth();
        saveData.savedHunger = pet.GetHunger();
        saveData.savedHappiness = pet.GetHappiness();
        json = JsonUtility.ToJson(saveData);
        File.WriteAllText(path, json);
    }
    public void loadFromJson()
    {
        if (File.Exists(path))
        {
            json = File.ReadAllText(path);
            SaveData saveData = JsonUtility.FromJson<SaveData>(json);
            pet.SetHealth(saveData.savedHealth);
            pet.SetHunger(saveData.savedHunger);
            pet.SetHappiness(saveData.savedHappiness);
        }
    }
    #endregion
}
