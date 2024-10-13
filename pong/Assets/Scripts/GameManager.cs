using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    public static GameManager Instance
    {
        get { return instance; }
    }

    
    public int scoreP1;
    public int scoreP2;
    public int maxPoints;
    
    public TextMeshProUGUI TextScoreP1; 
    public TextMeshProUGUI TextScoreP2;
    public TextMeshProUGUI TextGameOver;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

       
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreP1 = 0;
        scoreP2 = 0;
        UpdateScoreText();
        TextGameOver.gameObject.SetActive(false);
    }

    public void PointP1()
    {
        scoreP1++;

        UpdateScoreText();
        if(scoreP1 >= maxPoints)
        {
            TextGameOver.gameObject.SetActive(true);
            TextGameOver.text = "P1 Wins!";
            Time.timeScale=0;
        }
    }

    public void PointP2()
    {
        scoreP2++;
        UpdateScoreText(); 
        if(scoreP2 >= maxPoints)
        {
            TextGameOver.gameObject.SetActive(true);
            TextGameOver.text = "P2 Wins!";
            Time.timeScale=0;
        }
    }

    // Update score display text
    private void UpdateScoreText()
    {
        TextScoreP1.text = scoreP1.ToString(); // 
        TextScoreP2.text = scoreP2.ToString(); // 
    }
}
