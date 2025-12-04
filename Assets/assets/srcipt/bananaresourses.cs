using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;


public class bananaresourses : MonoBehaviour
{
    public TMP_Text resourse;
    public bool start;
    public Image Banana;
    public Image Resourse;
    public Image Button;

    public List<Sprite> arbuziki = new();

    void Start()
    {
      Banana.fillAmount= 0;

    }



    // Update is called once per frame
    void Update()
    {
        Banana.fillAmount += Time.deltaTime;
        if (Banana.fillAmount >=1)
        {
            Banana.fillAmount = 0;
        }


    }
}
