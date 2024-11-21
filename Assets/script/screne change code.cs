using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;


public class screnechangecode : MonoBehaviour
{
    public void SwichScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
