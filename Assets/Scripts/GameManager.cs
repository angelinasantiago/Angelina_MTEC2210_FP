using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshPro scoretext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString("0000");
    }

    public void increasescore(int value)
    {
        score += value;
    }

    public void restartgame()
    {
        SceneManager.LoadScene(0);
    }

    public void youlose()
    {
        SceneManager.LoadScene(1);
    }

    public void youwin()
    {
        SceneManager.LoadScene(2);
    }
}
