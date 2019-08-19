using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void LoadToScene(int ScenetoLoad)
    {
        SceneManager.LoadScene("Main");
    }
}