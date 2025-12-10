
using System.Runtime.CompilerServices;
using TMPro;

using UnityEngine;
using UnityEngine.InputSystem.iOS;
using UnityEngine.UI;

public class CLOCKTIMER : MonoBehaviour
{
    public bool start;

    public float time;
    public TMP_Text timerTwxt;
    public Image clock;
    public float sufferDuration;

    public Image Banana;
    float resourse_count = 0;
    public TMP_Text resourse;

    private int roundcounter = 0;
    public TMP_Text round_cntr;

    [SerializeField] Button click; 

    public void Start_Click()
    {
        if (start) return;
        time = sufferDuration;
        start = true;
        resourse_count -= 5;
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
    public void button_activity()
    {
        if (resourse_count < 5)
        {
            click.gameObject.SetActive(false);
        }
        else
        {
            click.gameObject.SetActive(true);
        }
    }
    private void Update()
    {
        button_activity();
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
            //timerTwxt.text = roundcounter.ToString();
            round_cntr.text = Mathf.Round(roundcounter).ToString();
        }
        if (time <= 0)
        {
            start = false;
            clock.fillAmount = 1;
        }
    }
}






