using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneRandom : MonoBehaviour
{


    [SerializeField] private GameObject ANALYTICS;

    void Start()
    {

    }


    public void LoadRandomScene(int Levels)
    {
        int random = Random.Range(18, 22);
        SceneManager.LoadScene(random, LoadSceneMode.Single);
    }


}