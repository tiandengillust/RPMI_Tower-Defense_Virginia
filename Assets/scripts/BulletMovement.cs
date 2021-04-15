using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [Tooltip("Velocidad de la bala")]
    public float bulletSpeed;

    [Tooltip("Referencia al enemigo que voy a matar")]
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, bulletSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // La bala se destruye en cuanto colisiona con algún objeto
        Destroy(gameObject);
    }
}
