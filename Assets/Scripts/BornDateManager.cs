using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BornDateManager : MonoBehaviour
{

    [SerializeField] private RectTransform dayContentRect;
    private string bornDatePrefabPath = GameConstants.BORN_DATE_PREFAB_PATH;
    private GameObject dayNumberPrefab;

    private void Start()
    {
        dayNumberPrefab = Resources.Load<GameObject>(bornDatePrefabPath);
        CreateAllDayNumbers();
    }


    private void CreateAllDayNumbers()
    {
        for (int i = 0; i < 31; i++)
        {
            GameObject number = Instantiate(dayNumberPrefab);
            number.GetComponent<NumberController>().Text.SetText(i.ToString());
            number.GetComponent<RectTransform>().parent = dayContentRect;
        }
    }

}
