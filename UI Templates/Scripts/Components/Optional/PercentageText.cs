using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PercentageText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMesh;
    [SerializeField] private Image _image;

    private void Update()
    {
        _textMesh.text = $"{(int)(_image.fillAmount * 100)}%";
    }
}
