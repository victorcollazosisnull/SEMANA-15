using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    private Transform _transform;
    public GameObject enemyPrefab;
    public float TimeCreateEnemy = 1;
    public float TimeActually = 0;
    public GameManagerControl gameManagerControl;
    // Start is called before the first frame update
    void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    void Update()
    {
        TimeActually = TimeActually + Time.deltaTime;
        if(TimeActually >= TimeCreateEnemy)
        {
            TimeActually = 0;
            CreateEnemy();
        }
    }
    void CreateEnemy()
    {
        float randomX = Random.Range(-8.04f, 8.04f);
        float randomY = 4.25f;
        _transform.position = new Vector2(randomX, randomY);
        Instantiate(enemyPrefab, _transform.position,transform.rotation);
    }
    public void IncreasePoints(int pointsToAdd)
    {
        gameManagerControl.IncreasePoints(pointsToAdd);
    }
}
