using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void ButtonRestart()
    {
        SceneManager.LoadScene("FirstLevel");
    }
}
