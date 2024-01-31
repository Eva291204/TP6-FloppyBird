using System.Collections;
using UnityEngine;

public class PipesSpawn : MonoBehaviour
{
    [SerializeField] private PipesPool _pipesPool;
    [SerializeField] private float _heightSpawn;

    public float WaitNewPipes;

    public void Spawn()
    {
        if (GameManager.Instance.GameIsStart)
        {
            GameObject obj = _pipesPool.GetObjectFromPool();
            if (obj != null)
            {
                obj.transform.position = new Vector3(gameObject.transform.position.x, Random.Range(-_heightSpawn, _heightSpawn)) ;
                obj.SetActive(true);
                StartCoroutine(WaitSpawnPipes());
            }
        }
    }

    IEnumerator WaitSpawnPipes()
    {
        yield return new WaitForSeconds(WaitNewPipes);
        Spawn();
    }
}
