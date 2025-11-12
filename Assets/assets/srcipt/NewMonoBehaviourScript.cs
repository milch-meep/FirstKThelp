using UnityEngine;
using TMPro;
using System.Linq;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public TMP_Text IText;
    
    public void Decrypt()
    {
        IText.text = IText.text.Replace("*", "u");
    }

    public void Correct()
    {
        IText.text = IText.text.Replace(">", "\n");
    }

    public void Peel()
    {
        IText.text = IText.text.Replace("$", "");
        IText.text = IText.text.TrimEnd('z');
    }
    public void Loh()
    {
        IText.text = IText.text.Replace('a', '%');
        IText.text = IText.text.();


    }
}
