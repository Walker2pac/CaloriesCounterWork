using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DescriptionPanelController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI name;

    public void SetDescriptionName(string name)
    {
        this.name.SetText(name);
    }
}
