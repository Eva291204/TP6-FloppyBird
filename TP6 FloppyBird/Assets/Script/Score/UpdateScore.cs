using TMPro;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    public int Score;

    public void OnTriggerEnter(Collider collider)
    {
        Score++;
        _scoreText.text = "Score : " + Score;
    }
}
