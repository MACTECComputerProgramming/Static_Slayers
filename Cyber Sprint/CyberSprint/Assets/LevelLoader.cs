using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public void LoadLevel(int sceneIndex)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);


    }
    

}
