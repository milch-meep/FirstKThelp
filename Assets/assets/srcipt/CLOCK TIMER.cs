using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CLOCKTIMER : MonoBehaviour
{
    public TMP_Text timerTwxt;
    public bool start;
    public float time;

    public void Start_Click()
    {
        start = true;
    }

    private void Start()
    {
        timerTwxt.text = time.ToString();
    }

    private void Update()
    {
        if (start == false)
        {
        time -= Time.deltaTime;
        timerTwxt.text = Mathf.Round(time).ToString();

        }

        
    }
}


