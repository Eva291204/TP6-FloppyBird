using System.Collections;
using UnityEngine;

public class PipesMove : MonoBehaviour
{
    [SerializeField] private float _pipesSpeed;
    [SerializeField] private float _waitDispawn;

    public void Update()
    {
        transform.position += Vector3.left * _pipesSpeed * Time.deltaTime;
        StartCoroutine(WaitToDispawn());
    }
    public IEnumerator WaitToDispawn()
    {
        yield return new WaitForSeconds(_waitDispawn);
        transform.position = Vector3.zero;
        gameObject.SetActive(false);
    }
}
