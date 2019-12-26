using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DescriptionPanelController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI calories;
    [SerializeField] private TextMeshProUGUI protein;
    [SerializeField] private TextMeshProUGUI fats;
    [SerializeField] private TextMeshProUGUI carbohydrate;
    [SerializeField] private GameObject descriptionPanel;
    

    public void SetDescriptionName(string name, string description, string calories, int protein, int fats, int carbohydrate)
    {
        this.name.SetText(name);
        this.description.SetText(description);
        this.calories.SetText(calories);
        this.protein.SetText(protein.ToString());
        this.fats.SetText(fats.ToString());
        this.carbohydrate.SetText(carbohydrate.ToString());
    }

    public void CloseDescriptionPanel()
    {
        descriptionPanel.SetActive(false);
    }
    
}
