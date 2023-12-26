using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    public void LoadFirstGameplayScene() => SceneManager.LoadScene(1);
}
