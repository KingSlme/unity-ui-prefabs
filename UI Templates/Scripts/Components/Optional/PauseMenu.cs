using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private KeyCode _pauseKey = KeyCode.Escape;
    private Canvas _pauseMenuCanvas;
    private bool _paused = false;

    private void Awake()
    {
        _pauseMenuCanvas = GetComponentInChildren<Canvas>(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(_pauseKey))
        {
            if (!_paused)
            {
                _paused = true;
                Time.timeScale = 0.0f;
                _pauseMenuCanvas.gameObject.SetActive(true);
            }
            else
            {
                _paused = false;
                Time.timeScale = 1.0f;
                _pauseMenuCanvas.gameObject.SetActive(false);
            }
        }

    }
}
