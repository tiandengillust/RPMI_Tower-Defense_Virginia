using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    [Tooltip("prefab de la bala")]
    public GameObject bulletPrefab;

    [Tooltip("enemigo al que voy a disparar")]
    public GameObject enemy;

    public float ratio;

    public float altura;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("disparo", 3, ratio);
    }
    
    private void disparo()
    {
        if (enemy != null)
        {
            GameObject bala = Instantiate(bulletPrefab, transform.position + new Vector3(0, altura, 0), Quaternion.identity);
            bala.GetComponent<BulletMovement>().enemy = enemy;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemy = other.gameObject;
        }
    }
}
