using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public EnemyContainerControl EnemyContainerControl;
    public float horizontal;
    public float speedX;
    private Rigidbody2D _rigidbody2D;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public AudioSource _audioSource;
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BulletShoot();
        }
    }
    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(horizontal * speedX, 0);
    }
    void BulletShoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.GetComponent<Bullet>().SetEnemyContainerControl(EnemyContainerControl);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = new Vector2(0, bulletSpeed);
        _audioSource.Play();
    }
}
