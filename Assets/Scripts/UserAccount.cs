using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserAccount : MonoBehaviour
{
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
    private int age;
    private bool gender;
    private string activeDiet;
    private string activeIntensity;

    public UserAccount()
    {
        
    }

    public UserAccount(string name, int age, bool gender, string activeDiet, string activeIntensity)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.activeDiet = activeDiet;
        this.activeIntensity = activeIntensity;
    }

}
