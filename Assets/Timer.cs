using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject Background1;
    public GameObject Background2;
    public GameObject Background3;
    public GameObject BackgroundBonusTime;
    public GameObject Floor1;
    public GameObject Floor2;
    public GameObject Floor3;
    public GameObject FloorBonusTime;

    public float Normaltimer = 40.0f;
    public float Bonustimer;
    public int BackgroundVar = 1;
    public bool Bonusperiod = false;
    // Start is called before the first frame update
    void Start()
    {
        Background1.SetActive(true);
        Floor1.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Normaltimer >= 0.1f && Bonusperiod == false)
        {
            Normaltimer -= Time.deltaTime;
        }
        if (Normaltimer < 0.1f && Bonusperiod == false)
        {
            Bonustimer = 6.0f;
            Bonusperiod = true;
            Bonustime();
            //StartBonustime
        }
        if (Bonustimer >= 0.1f && Bonusperiod == true)
        {
            Bonustimer -= Time.deltaTime;
        }
        if (Bonustimer < 0.1f && Bonusperiod == true)
        {
            EndBonusTime();
        }
    }
    void Bonustime()
    {
        BackgroundBonusTime.SetActive(true);
        FloorBonusTime.SetActive(true);
        Background1.SetActive(false);
        Floor1.SetActive(false);
        Background2.SetActive(false);
        Floor2.SetActive(false);
        Background3.SetActive(false);
        Floor3.SetActive(false);
    }
    void EndBonusTime()
    {
        Bonusperiod = false;
        BackgroundVar += 1;
        SetScene();
        Normaltimer = 40.0f;
        BackgroundBonusTime.SetActive(false);
        FloorBonusTime.SetActive(false);
    }    
    void SetScene()
    {
        if ((BackgroundVar % 3) == 1)
        {
            Background1.SetActive(true);
            Floor1.SetActive(true);
        }
        if ((BackgroundVar % 3) == 2)
        {
            Background2.SetActive(true);
            Floor2.SetActive(true);
        }
        if ((BackgroundVar % 3) == 0)
        {
            Background3.SetActive(true);
            Floor3.SetActive(true);
        }
    }

}
