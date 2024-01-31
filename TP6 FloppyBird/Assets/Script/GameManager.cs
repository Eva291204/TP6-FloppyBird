using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    public void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
    }

    [SerializeField] private PipesSpawn _pipesSpawn;
    [SerializeField] private TextMeshProUGUI _gameOverText;
    public bool GameIsStart;

    public void OnStart()
    {
        GameIsStart = true;
        _pipesSpawn.Spawn();
    }

    public void GameOver()
    {
        GameIsStart = false;
        _gameOverText.gameObject.SetActive(true);
        StartCoroutine(waitToReloadScene());
    }

    IEnumerator waitToReloadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("FloppyBird");
    }
}
