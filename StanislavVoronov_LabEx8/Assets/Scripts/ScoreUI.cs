using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    private Text _text;

    private void Start()
    { 
        _text = GetComponent<Text>();
        UpdateScore(0);
    }

    public void UpdateScore(int newScore)
    {
        _text.text = $"Score: {newScore}";
    }
}
