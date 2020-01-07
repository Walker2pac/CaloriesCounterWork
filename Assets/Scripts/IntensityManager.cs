using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntensityManager : MonoBehaviour
{

    private List<IntensityEntity> _allEntities = new List<IntensityEntity>();
    private string _path = "SportElement";
    private GameObject _intensityPrefab;
    private RectTransform _rectTransform;
    
    private void Start()
    {
        _intensityPrefab = Resources.Load<GameObject>(_path);
        _rectTransform = GetComponent<RectTransform>();
        CreateIntensityEntities();
        CreateIntensityElements();
    }

    private void CreateIntensityEntities()
    { 
        _allEntities.Add(new IntensityEntity("Сидячая работа"));
        _allEntities.Add(new IntensityEntity("Тренировка 1-2 раз в неделю"));
        _allEntities.Add(new IntensityEntity("Тренировка 2-3 раз в неделю"));
        _allEntities.Add(new IntensityEntity("Тренировка 4-6 раз в неделю"));
        _allEntities.Add(new IntensityEntity("Каждый день"));
    }

    private void CreateIntensityElements()
    {
        for (int i = 0; i < _allEntities.Count; i++)
        {
            GameObject intensity = Instantiate(_intensityPrefab);
            intensity.GetComponent<IntensityController>().SetIntensityEntity(_allEntities[i]); // сокращенная запись
            intensity.GetComponent<RectTransform>().parent = _rectTransform;
        }
    }

}
