    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class highscore : MonoBehaviour
{
    public TextMeshProUGUI highscoretext;
    // Start is called before the first frame update
    void Start()
    {
        highscoretext.text = "Highscore : " + ((int)PlayerPrefs.GetFloat("HighScore")).ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
