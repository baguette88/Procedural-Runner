using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public void LoadToScene(int sceneToLoad)
    {
        Application.LoadLevel (sceneToLoad);
        //OBSOLETE
    }
}