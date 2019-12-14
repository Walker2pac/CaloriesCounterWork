using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DietController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI energyText;
    
    public void SetDietEntity(DietEntity dietEntity)
    {
        nameText.SetText(dietEntity.Name);
        energyText.SetText(dietEntity.Squirrels + "/" + dietEntity.Fats + "/" + dietEntity.Carbohydrates);
    }
}
