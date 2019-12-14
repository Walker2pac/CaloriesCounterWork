using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject loginScreen;
    [SerializeField] private GameObject registrationScreen;
    
    private void Start()
    {
        ActivateAutorizationScreen();
    }

    private void ActivateAutorizationScreen()
    {
        registrationScreen.SetActive(false);
        loginScreen.SetActive(true);
    }

    public void OnRegistration()
    {
        loginScreen.SetActive(false);
        registrationScreen.SetActive(true);
    }

    public void BackFromStage1()
    {
        loginScreen.SetActive(true);
        registrationScreen.SetActive(false);
    }
    
}
