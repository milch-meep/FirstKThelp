using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;


public class bananaresourses : MonoBehaviour
{
    public TMP_Text resourse;
    public bool start;
    public Image Banana;
    public Image Resourse;
    public Image Button;

    public List<Sprite> arbuziki = new();
    float resourse_count = 0;

    void Start()
    {
      Banana.fillAmount= 0;
    

    }
    // Update is called once per frame
    void Update()
    {
        if (Banana.fillAmount >= 1)
        {
        Banana.fillAmount += Time.deltaTime;
            resourse_count += 1;
            resourse.text = Mathf.Round(resourse_count).ToString();
        }
        if (Banana.fillAmount >=1)
        {
            Banana.fillAmount = 0;
        }

    }
}
