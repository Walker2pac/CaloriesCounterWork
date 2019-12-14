using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DietEntity
{
    private string name;
    private int squirrels;
    private int fats;
    private int carbohydrates;

    public DietEntity(string name, int squirrels, int fats, int carbohydrates)
    {
        this.name = name;
        this.fats = fats;
        this.squirrels = squirrels;
        this.carbohydrates = carbohydrates;
    }

    public string Name => name;

    public int Squirrels => squirrels;

    public int Fats => fats;

    public int Carbohydrates => carbohydrates;
}
