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
    [SerializeField] private GameObject closeDescriptionPanelButton;
    private DescriptionPanelController _dpc;
    
    private void Start()
    {
        descriptionButton.onClick.AddListener(ActivateDietInfo);
    }

    public void SetDietEntity(DietEntity dietEntity)
    {
        nameText.SetText(dietEntity.Name);
        energyText.SetText(dietEntity.Protein + "/" + dietEntity.Fats + "/" + dietEntity.Carbohydrates);
    }

    private void ActivateDietInfo()
    {
        _dpc = FindObjectOfType<RegManager>().GetDietDescriptionPanel().GetComponent<DescriptionPanelController>();
        _dpc.SetDescriptionName(nameText.text);
        ActiveDietDescriptionPanel();
    }
    
    private void ActiveDietDescriptionPanel()
    {
        _dpc.gameObject.SetActive(true);
        
    }
    
    private void CloseDietDescriptionPanel()
    {
        _dpc.gameObject.SetActive(false);
    }
}
