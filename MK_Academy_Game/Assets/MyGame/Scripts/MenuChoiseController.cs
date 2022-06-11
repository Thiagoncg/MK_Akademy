using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuChoiseController : MonoBehaviour
{
    // UI VAriables
    [SerializeField] private GameObject ImageHumanoElfo;
    [SerializeField] private GameObject ImageGenderHuman;
    [SerializeField] private GameObject ImageGenderElfo;


    void Start()
    {
        StartControllerMenus();
    }
    private void StartControllerMenus()
    {
        ImageHumanoElfo.SetActive(true);
        ImageGenderHuman.SetActive(false);
        ImageGenderElfo.SetActive(false);
    }
}
