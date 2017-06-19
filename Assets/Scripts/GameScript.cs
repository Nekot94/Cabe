﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public GameObject player;
    public Text scoreText;
    public Text gameOverText;
    public int maxScore;
    private HeroScript heroScript;

    private void Start()
    {
       heroScript = player.GetComponent<HeroScript>();
    }

    private void Update()
    {
        scoreText.text = "Очки: " + heroScript.scores.ToString() + "/" + maxScore.ToString();
        if (heroScript.scores  >= maxScore)
        {
            gameOverText.text = "Ты победитель";
            StartCoroutine(Restart());
        }
        

    }

    private IEnumerator Restart()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);     
    }





}
