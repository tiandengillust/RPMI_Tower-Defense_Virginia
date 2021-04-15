using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [Tooltip("Referencia al prefab de la bala")]
    public GameObject bulletPrefab;

    [Tooltip("Referencia al enemigo que voy a disparar")]
    public GameObject enemy;

    public float altura;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bala = Instantiate(bulletPrefab, transform.position + new Vector3(0, altura, 0), Quaternion.identity);
            bala.GetComponent<BulletMovement>().enemy = enemy;
        }
    }
}
