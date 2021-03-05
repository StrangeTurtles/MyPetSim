using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatSlider : MonoBehaviour
{
    public Slider statSlider;
    public PetStats pet;
    public enum Stat
    {
        HEALTH,
        HUNGER,
        HAPPINESS
    }
    public Stat stat = Stat.HAPPINESS;
    // Start is called before the first frame update
    void Start()
    {
        statSlider.maxValue = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        switch (stat)
        {
            case Stat.HEALTH:
                statSlider.value = pet.GetHealth();
                break;
            case Stat.HUNGER:
                statSlider.value = pet.GetHunger();
                break;
            case Stat.HAPPINESS:
                statSlider.value = pet.GetHappiness();
                break;
            default:
                break;
        }
    }
}
