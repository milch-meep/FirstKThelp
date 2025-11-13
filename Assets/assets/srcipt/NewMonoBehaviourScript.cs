using System;
using System.Linq;
using System.Xml;
using TMPro;
using UnityEngine;
using static UnityEngine.UI.Image;
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
        IText.text = IText.text + "Lmao";
        ReversLoha();
    }
    public void ReversLoha()
    {
        string originalText = IText.text;
        string[] lines = originalText.Split('\n');

        for (int i = 0; i < lines.Length; i++)
        {
            char[] chars = lines[i].ToCharArray();
            System.Array.Reverse(chars);
            lines[i] = new string(chars);
        }

        IText.text = string.Join("\n", lines);
    }
}

