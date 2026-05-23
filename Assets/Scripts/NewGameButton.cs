using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
   
    public void LoadFirstLevel(SceneAsset sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad.name);
    }


}
