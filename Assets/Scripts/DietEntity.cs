using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DietEntity
{
    private string name;
    private int protein;
    private int fats;
    private int carbohydrates;
    

    public DietEntity(string name, int protein, int fats, int carbohydrates)
    {
        this.name = name;
        this.fats = fats;
        this.protein = protein;
        this.carbohydrates = carbohydrates;
    }

    public string Name => name;

    public int Protein => protein;

    public int Fats => fats;

    public int Carbohydrates => carbohydrates;
}
