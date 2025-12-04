using JetBrains.Annotations;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class CLOCKTIMER : MonoBehaviour
{
    public TMP_Text timerTwxt;
    public TMP_Text timerTwy;
    public bool start;
    public float time;
    private int roundcounter = 0;

    public float sufferDuration;
    public Image clock;

    public void Start_Click()
    {
        if (start) return;
        time = sufferDuration;
        start = true;

    }

    private void Start()
    {
        timerTwxt.text = time.ToString();
    }
    public void StartSuffer()
    {
        if (start == true)
        {
            clock.fillAmount -= (1 / sufferDuration) * Time.deltaTime;
        }
        else
        {
            clock.fillAmount = 1;
            start = false;
        }
    }
    private void Update()
    {
        if (start == true)
        {
            time -= Time.deltaTime;
            timerTwxt.text = Mathf.Round(time).ToString();
        }
        StartSuffer();
        if (clock.fillAmount == 0)
        {
            roundcounter += 1;
            timerTwy.text = roundcounter.ToString();
        }
        if (time <= 0)
        {
            start = false;
            clock.fillAmount = 1;
        }
    }
}


