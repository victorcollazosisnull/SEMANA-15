using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosionPrefab;
    public EnemyContainerControl enemyContainerControl;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ParedGozu"))
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Enemigos")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            GameObject gameObject = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject, 0.5f);
            enemyContainerControl.IncreasePoints(1); 
        }
    }
    public void SetEnemyContainerControl(EnemyContainerControl enemyContainerControl)
    {
        this.enemyContainerControl = enemyContainerControl;
    }
}
