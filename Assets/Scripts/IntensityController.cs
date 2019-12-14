using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntensityController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI intensityText;

    public void SetIntensityEntity(IntensityEntity intensityEntity)
    {
        intensityText.SetText(intensityEntity.Name);
    }

}
