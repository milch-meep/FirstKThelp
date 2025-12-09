
using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class CLOCKTIMER : MonoBehaviour
{
    public TMP_Text timerTwxt;
    public TMP_Text resourse;
    public bool start;
    public Image Banana;
    public float time;
    private int roundcounter = 0;
    float resourse_count = 0;
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
    public void banana()
    {

        //Banana.fillAmount += Time.deltaTime;
        if (Banana.fillAmount >= 1)
        {
            resourse_count += 1;
            resourse.text = Mathf.Round(resourse_count).ToString();
            Banana.fillAmount = 0;
        }


    }
    private void Update()
    {
        Banana.fillAmount += Time.deltaTime;
        banana();

        if (start == true)
        {
            time -= Time.deltaTime;
            timerTwxt.text = Mathf.Round(time).ToString();
        }
        StartSuffer();
        if (clock.fillAmount == 0)
        {
            roundcounter += 1;
            timerTwxt.text = roundcounter.ToString();
        }
        if (time <= 0)
        {
            start = false;
            clock.fillAmount = 1;
        }

    }
}


