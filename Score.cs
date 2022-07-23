using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float score = 0.0f;
    private bool vOut = false;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        if (vOut)
            return;
        score += Time.deltaTime;
        scoreText.text = ((int)score).ToString();
        
    }
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obsticle")
        {
            death();
        }
    }
    private void death()
    {
        if(PlayerPrefs.GetFloat("HighScore") < score)
        PlayerPrefs.SetFloat("HighScore", score);

        vOut = true;
    }
   
}
