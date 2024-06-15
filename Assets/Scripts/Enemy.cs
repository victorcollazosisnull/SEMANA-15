using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform _transform;
    public float speedY;   
    // Start is called before the first frame update
    void Awake()
    {
        _transform = GetComponent<Transform>();
    }



    private void FixedUpdate()
    {
        _transform.position = new Vector2(_transform.position.x, _transform.position.y - speedY * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("KillEnemigo"))
        {
            Destroy(this.gameObject);
        }
    }
    
}
