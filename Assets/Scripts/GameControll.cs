using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameControll : MonoBehaviour
{
    public static GameControll instance;
	
    public int ballsCount = 25;
    private float score = 0;
	public TextMeshProUGUI text_score;
    public TextMeshProUGUI txt_score;
    public TextMeshProUGUI gameOwer;
    //public Button button;

    public float speedCamera = 5f;

    public AudioSource glassBroken = new AudioSource();
    public AudioSource audio_dammage;


    void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
	}

    private void Start()
    {
        text_score.text = "" + ballsCount;
        //button.onClick.AddListener(MenuBTN);
    }


    void Update()
    {
        score += Time.deltaTime;
        txt_score.text = "Score: " + Mathf.RoundToInt(score);
        if(ballsCount <= 0)
        {
            text_score.gameObject.SetActive(false);
            gameOwer.gameObject.SetActive(true);
            //button.gameObject.SetActive(true);
            speedCamera = 1f;
        }
    }
}

