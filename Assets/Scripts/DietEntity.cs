using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DietEntity
{
    private string name;
    private string description;
    private string calories;
    private int protein;
    private int fats;
    private int carbohydrates;
    

    public DietEntity(string name, string description, string calories, int protein, int fats, int carbohydrates)
    {
        this.name = name;
        this.description = description;
        this.calories = calories;
        this.fats = fats;
        this.protein = protein;
        this.carbohydrates = carbohydrates;
    }

    public string Name => name;
    public string Description => description;
    public string Calories => calories;
    public int Protein => protein;

    public int Fats => fats;

    public int Carbohydrates => carbohydrates;
}
