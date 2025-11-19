using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENECHAGER : MonoBehaviour
{

    public void ChangeScene(int insex)
    {
        SceneManager.LoadScene(insex);
    }

    public void OpenGame()
    {
        SceneManager.LoadScene(1);
    }
}

    
