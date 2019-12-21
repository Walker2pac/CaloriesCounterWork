using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RegManager : MonoBehaviour
{

    [SerializeField] private GameObject stage1;
    [SerializeField] private GameObject stage2;
    [SerializeField] private TMP_InputField inputWeight;
    [SerializeField] private TMP_InputField inputWeight2;
    [SerializeField] private TMP_InputField inputHeight;
    [SerializeField] private GameObject panelIntensity;
    [SerializeField] private GameObject panelDiet;
    [SerializeField] private GameObject warningPanel;
    [SerializeField] private GameObject intensityButton;
    [SerializeField] private GameObject dietButton;
    [SerializeField] private GameObject closeInfoButton;
    private bool onOffReg = false;
    
    private void Start()
    {
        ActivateStage1();
    }
    
    public void ActivateStage1()
    {
        stage2.SetActive(false);
        stage1.SetActive(true);
    }
    
    public void ActivateStage2()
    {
        if (onOffReg)
        {
            if (inputWeight.text == "" || inputHeight.text == "" || inputWeight2.text == "")
            {
                warningPanel.SetActive(true);
            }
            else
            {
                stage1.SetActive(false);
                stage2.SetActive(true);
            }
        }
        else
        {
            stage1.SetActive(false);
            stage2.SetActive(true);
        }
    }

    public void ActiveIntensity()
    {
        panelIntensity.SetActive(true);
        closeInfoButton.SetActive(true);
        intensityButton.SetActive(false);
        dietButton.SetActive(false);
    }
    
    public void ActiveDiet()
    {
        panelDiet.SetActive(true);
        closeInfoButton.SetActive(true);
        intensityButton.SetActive(false);
        dietButton.SetActive(false);
    }

    public void CloseInfoPanel()
    {
        closeInfoButton.SetActive(false);
        panelDiet.SetActive(false);
        panelIntensity.SetActive(false);
        intensityButton.SetActive(true);
        dietButton.SetActive(true);
    } 
    
    public void CloseInfoAttention()
    {
        warningPanel.SetActive(false);
    }
    
}

