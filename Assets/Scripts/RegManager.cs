using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RegManager : MonoBehaviour
{
    #region Singletone

    private static RegManager _instance;

    public static RegManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<RegManager>();
            }

            return _instance;
        }
    }

    #endregion
    
    [SerializeField] private GameObject stage1;
    [SerializeField] private GameObject stage2;
    [SerializeField] private GameObject stage3;
    [SerializeField] private TMP_InputField inputWeight;
    [SerializeField] private TMP_InputField inputAge;
    [SerializeField] private TMP_InputField inputHeight;
    [SerializeField] private GameObject panelIntensity;
    [SerializeField] private GameObject panelDiet;
    [SerializeField] private GameObject warningPanel;
    [SerializeField] private GameObject intensityButton;
    [SerializeField] private GameObject dietButton;
    [SerializeField] private GameObject closeInfoButton;
    [SerializeField] private GameObject dietDescriptionPanel;
    [SerializeField] private bool debug = true;
    [SerializeField] private GameObject panelQuestion;
    [SerializeField] private GameObject choosePanel;
    [SerializeField] private TextMeshProUGUI chooseText;
    [SerializeField] private GameObject womanButton;
    [SerializeField] private GameObject manButton;

    private void Start()
    {
        ActivateStage1();
    }
    public void ActivateStage1()
    {
        stage1.SetActive(true);
        stage2.SetActive(false);
        stage3.SetActive(false);
    }
    public void ActivateStage2()
    {
        if (!debug)
        {
            if (inputWeight.text == "" || inputHeight.text == "" || inputAge.text == "")
            {
                warningPanel.SetActive(true);
            }
            else
            {
                stage1.SetActive(false);
                stage2.SetActive(true);
                stage3.SetActive(false);
            }
        }
        else
        {
            stage1.SetActive(false);
            stage2.SetActive(true);
            stage3.SetActive(false);
        }
    }
    public void ActivateStage2f()
    {
        stage1.SetActive(false);
        stage2.SetActive(true);
        stage3.SetActive(false);
    }
    public void ActivateStage3()
    {
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(true);
    }
    public void ActiveDiet()
    {
        panelDiet.SetActive(true);
        closeInfoButton.SetActive(true);
        panelQuestion.SetActive(true);
        choosePanel.SetActive(true);
        chooseText.SetText(GameConstants.CHOOSE_TEXT_DIET);
        intensityButton.SetActive(false);
        dietButton.SetActive(false);
        womanButton.SetActive(false);
        manButton.SetActive(false);
    }
    public void ActiveIntensity()
    {
        panelIntensity.SetActive(true);
        closeInfoButton.SetActive(true);
        panelQuestion.SetActive(true);
        choosePanel.SetActive(true);
        chooseText.SetText(GameConstants.CHOOSE_TEXT_INTENSITY);
        intensityButton.SetActive(false);
        dietButton.SetActive(false);
        womanButton.SetActive(false);
        manButton.SetActive(false);
    }

    public void CloseInfoPanel()
    {
        closeInfoButton.SetActive(false);
        dietDescriptionPanel.SetActive(false);
        panelDiet.SetActive(false);
        panelIntensity.SetActive(false);
        panelQuestion.SetActive(false);
        choosePanel.SetActive(false);
        intensityButton.SetActive(true);
        dietButton.SetActive(true);
        womanButton.SetActive(true);
        manButton.SetActive(true);
    }
    public void CloseAttention()
    {
        warningPanel.SetActive(false);
    }
    public GameObject GetDietDescriptionPanel()
    {
        return dietDescriptionPanel;
    }
}

