using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserAccount : MonoBehaviour
{
    public int Weight
    {
        get => weight;
        set => weight = value;
    }

    public int Height
    {
        get => height;
        set => height = value;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }
    public int Age
    {
        get => age;
        set => age = value;
    }
    public bool Gender
    {
        get => gender;
        set => gender = value;
    }
    public string ActiveDiet
    {
        get => activeDiet;
        set => activeDiet = value;
    }
    public string ActiveIntensity
    {
        get => activeIntensity;
        set => activeIntensity = value;
    }

    private string name;
    private int weight;
    private int height;
    private int age;
    private bool gender;
    private string activeDiet;
    private string activeIntensity;

    public UserAccount(string name, int weight, int height, int age,   bool gender, string activeDiet, string activeIntensity)
    {
        this.name = name;
        this.weight = weight;
        this.height = height;
        this.age = age;
        this.gender = gender;
        this.activeDiet = activeDiet;
        this.activeIntensity = activeIntensity;
    }

}
