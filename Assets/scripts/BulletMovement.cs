using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [Tooltip("Velocidad bala")]
    public float bulletSpeed;

    [Tooltip("Referencia a enemigo")]
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, bulletSpeed);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
