using System.Collections.Generic;
using UnityEngine;

public class PipesPool : MonoBehaviour
{
    [SerializeField] private int _poolSize;

    public GameObject PoolPrefab;
    private List<GameObject> _poolList;

    private void Start()
    {
        _poolList = new List<GameObject>();

        for (int i = 0; i < _poolSize; i++)
        {
            GameObject obj = Instantiate(PoolPrefab);
            obj.SetActive(false);
            _poolList.Add(obj);
        }
    }

    public GameObject GetObjectFromPool()
    {
        foreach (GameObject obj in _poolList)
        {
            if (!obj.activeInHierarchy)
            { return obj; }
        }

        return null;
    }
}
