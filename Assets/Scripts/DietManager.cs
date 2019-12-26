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
    private RectTransform _rectTransform;
    private GameObject _dietElement;
    private string _dietPath = "DietElement";
    [SerializeField] private GameObject dietDescriptionPanel;

    
    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
         Initialize();
    }

    private void Start()
    {
        CreateDietElements();
    }

    private void Initialize()
    {
        DietEntity diet = new DietEntity("Стандартная", "Диета, рассчитанная на сбалансированное питание и поддержаение веса.", "Норма калорий: 100%",30, 20, 50);
        DietEntity diet2 = new DietEntity("Классическая(снижение веса -10%)", "Диета, рассчитанная на сбалансированное питание и безопасное снижение веса.", "Норма калорий: 100%",18, 29, 53);
        DietEntity diet3 = new DietEntity("Диета Зона", "Диета Зона для похудения была составлена известным доктором Б. Сирсом. Профессор Сирс считает, что диета Зона является наилучшим средством ругулирования уровня инсулина в организме. Диета Зона длится 14 дней.", "Норма калорий: 90%",30, 30, 40);
        DietEntity diet4 = new DietEntity("Диета Аткинса", "Низкоуглеводная диета, разработанная кардиологом Робертом Аткинсом. Диета Аткинса ограничевает потребление углеводов для переключения обмена веществ с использования в качестве энергетического топлива глюкозы на сжигание накопленных в теле человека жиров.", "Норма калорий: 100%",20, 75, 5);
        DietEntity diet5 = new DietEntity("Высокоуглеводная (наращивание мышц +10%)", "Диета с высоким содержанием углеводов подходит для людей, которым нужно набрать вес или нарастить мышечную массу.", "Норма : 100%",25, 15, 60); DietEntity diet6 = new DietEntity("Низкоуглеводная (снижение веса -10%)", "Не секрет, что главной причиной ожирения является излишнее потребление углеводов, поэтому задача низкоуглеводной диеты - минимализировать поступление углеводов в организм.", "Норма калорий",40, 35, 25);
        DietEntity diet7 = new DietEntity("Диета кетогенная (сушка)", "Кетогенная диета - это диета, обогащенная жирами и протеинами при экстремально низком содержании углеводов (обычно менее 10% от общего количества макронутриентов); при таком питании организм вынужден использовать в качестве топлива жиры, поскольку запасы глюкозы быстро истощаются.", "Норма калорий: 90%",45, 45, 10);
        
        allDiets.Add(diet);
        allDiets.Add(diet2);
        allDiets.Add(diet3);
        allDiets.Add(diet4);
        allDiets.Add(diet5);
        allDiets.Add(diet6);
        allDiets.Add(diet7);
    }

    private void CreateDietElements()
    {
        _dietElement = Resources.Load<GameObject>(_dietPath);
        for (int i = 0; i < allDiets.Count; i++)
        {
            GameObject diet = Instantiate(_dietElement);
            diet.GetComponent<DietController>().SetDietEntity(allDiets[i]);
            diet.GetComponent<RectTransform>().parent = _rectTransform;
        }
        dietDescriptionPanel.transform.SetAsLastSibling();
    }
}
