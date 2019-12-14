using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DietController : MonoBehaviour
{
    [SerializeField] private GameObject info;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI energyText;
    [SerializeField] private GameObject description;
    [SerializeField] private Button[] allObjects;
    private DietEntity diet;
    
    private void Awake()
    {
        allObjects = gameObject.GetComponentsInChildren<Button>();
        info = allObjects[0].gameObject;
        description = allObjects[1].gameObject;
        
        nameText = info.GetComponentsInChildren<TextMeshProUGUI>()[0];
        energyText = info.GetComponentsInChildren<TextMeshProUGUI>()[1];
        
        CheckReference();
    }

    private void Start()
    {
        Initialize();
    }

    private void CheckReference()
    {
        if(info) Debug.Log("info exists");
        else Debug.Log("info doesn't exist");
        if(description) Debug.Log("description exists");
        else Debug.Log("description doesn't exist");
    }

    private void Initialize()
    {
        diet = DietManager.Instance.GetDietEntity();
        nameText.SetText(diet.Name);
        energyText.SetText(diet.Squirrels + "/" + diet.Fats + "/" + diet.Carbohydrates);
    }
    
}
