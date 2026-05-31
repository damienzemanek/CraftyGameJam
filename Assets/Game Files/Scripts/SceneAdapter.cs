using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAdapter : MonoBehaviour
{
    public GameSceneManager.Scenes sceneToLoad;
    public void LoadScene() => SceneManager.LoadScene(GameSceneManager.Instance.GetScene(sceneToLoad));
    public void Quit() => Application.Quit();
}