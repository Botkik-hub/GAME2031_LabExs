using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private void Start()
    { 
        _text = GetComponent<TextMeshProUGUI>();
        UpdateScore(0);
    }

    public void UpdateScore(int newScore)
    {
        _text.text = $"Score: {newScore}";
    }
}
