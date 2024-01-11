using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class UiFunkction : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadNextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex + 1 <= SceneManager.loadedSceneCount)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1  );
    }

}
