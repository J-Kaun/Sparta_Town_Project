using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinBtn : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("IntroScene");
    }
}