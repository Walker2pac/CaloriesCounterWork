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
    [SerializeField] private Button descriptionButton;
    private DescriptionPanelController _dpc;
    private DietEntity _dietEntity;
    
    private void Start()
    {
        descriptionButton.onClick.AddListener(ActivateDietInfo);
    }

    public void SetDietEntity(DietEntity dietEntity)
    {
        nameText.SetText(dietEntity.Name);
        energyText.SetText(dietEntity.Protein + "/" + dietEntity.Fats + "/" + dietEntity.Carbohydrates);
        this._dietEntity = dietEntity;
    }

    private void ActivateDietInfo()
    {
        _dpc = FindObjectOfType<RegManager>().GetDietDescriptionPanel().GetComponent<DescriptionPanelController>();
        _dpc.SetDescriptionName(nameText.text, _dietEntity.Description, _dietEntity.Calories, _dietEntity.Protein, _dietEntity.Fats, _dietEntity.Carbohydrates );
        ActiveDietDescriptionPanel();
    }
    
    private void ActiveDietDescriptionPanel()
    {
        _dpc.gameObject.SetActive(true);
        
    }
    
/*    private void CloseDietDescriptionPanel()
    {
        _dpc.gameObject.SetActive(false);
    }*/
}
