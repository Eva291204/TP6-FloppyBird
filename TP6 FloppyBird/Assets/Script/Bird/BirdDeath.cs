using UnityEngine;

public class BirdDeath : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.GameOver();
    }
}
