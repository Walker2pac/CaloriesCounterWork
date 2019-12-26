using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IntensityController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI intensityText;
    [SerializeField] private Button agreeButton;
    private IntensityEntity _intensityEntity;

    private void Start()
    {
        agreeButton.onClick.AddListener(SetActiveIntensity);
    }

    public void SetIntensityEntity(IntensityEntity intensityEntity)
    {
        _intensityEntity = intensityEntity;
        intensityText.SetText(intensityEntity.Name);
    }
    
    private void SetActiveIntensity()
    {
        Debug.Log("Missgeburt");
        PlayerPrefs.SetString(GameConstants.KEY_INTENSITY_NAME, _intensityEntity.Name);
        RegManager.Instance.CloseInfoPanel();
    }

}
