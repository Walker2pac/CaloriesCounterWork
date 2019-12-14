using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DietManager : MonoBehaviour
{
    #region Singletone
    private static DietManager _instance;
    public static DietManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<DietManager>();
            }

            return _instance;
        }
    }
    #endregion
    
    [SerializeField] private List<DietEntity> allDiets = new List<DietEntity>();
    [SerializeField] private int index;
    
    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        DietEntity diet = new DietEntity("Стандартная", 30, 20, 50);
        DietEntity diet2 = new DietEntity("Жирная", 60, 120, 50);
        DietEntity diet3 = new DietEntity("Сладкая", 60, 120, 50);
        DietEntity diet4 = new DietEntity("Кетогенная", 60, 120, 50);
        DietEntity diet5 = new DietEntity("Сбалансированная", 60, 120, 50);
        DietEntity diet6 = new DietEntity("Полужирная", 60, 120, 50);
        DietEntity diet7 = new DietEntity("Кислая", 60, 120, 50);
        
        allDiets.Add(diet);
        allDiets.Add(diet2);
        allDiets.Add(diet3);
        allDiets.Add(diet4);
        allDiets.Add(diet5);
        allDiets.Add(diet6);
        allDiets.Add(diet7);
    }

    public DietEntity GetDietEntity()
    {
        Debug.Log("GetDietEntity");
        index++;
        Debug.Log("index = " + index);
        return allDiets[index];
    }
    
    
}
