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
    [SerializeField] private GameObject panelInfoDiet;
    [SerializeField] private GameObject textInfoDiet;
    [SerializeField] private GameObject warningPanel;
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

    public void ActiveIntensity()
    {
        panelIntensity.SetActive(true);
    }

    public void CloseIntensity()
    {
        panelIntensity.SetActive(false);
    }

    public void ActiveDiet()
    {
        panelDiet.SetActive(true);
    }
    
    public void CloseDiet()
    {
        panelDiet.SetActive(false);
    }

    public void ActiveTextInfoDiet()
    {
        panelInfoDiet.SetActive(true);
        textInfoDiet.SetActive(true);
    }

    public void CloseInfoAttention()
    {
        warningPanel.SetActive(false);
    }
    
}

