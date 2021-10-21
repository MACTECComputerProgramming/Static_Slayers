
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAftertime : MonoBehaviour
{

    [SerializeField]
    private float delayBeforeLoading = 7f;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;

   private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(1);
        }
    }
}
