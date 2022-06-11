using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadPlayGame : MonoBehaviour
{
    //UI Variables
    [SerializeField] private GameObject playButton;
    void Start() 
    {
        playButton.SetActive(false);
        StartCoroutine(PlayerSeconds());
    }
    
    public void PlayButton()
    {
        SceneManager.LoadScene("ChoicePlayers");
    }

    IEnumerator PlayerSeconds()
    {
        print(Time.time);//imprime o tempo atual do jogo
        yield return new WaitForSeconds(5);//aguarda 5 segundos
        print(Time.time);//imprime o tempo atual do jogo
        Debug.Log("Depois de 5 segundos");
        playButton.SetActive(true);
    }

}
