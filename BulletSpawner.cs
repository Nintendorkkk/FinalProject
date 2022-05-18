using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    #region Params
    [SerializeField] float BulletRate;
    [SerializeField] int minAngle;
    [SerializeField] int maxAngle;
    [SerializeField] float LaunchForce;
    [SerializeField] int DeathTime;
    #endregion
    void Start()
    {
        if (name == "Source")
        {
            #region Source Start
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            InvokeRepeating("SpawnBullet", 0f, BulletRate);
            #endregion
        }
        else
        {
            #region Other Bullet Start
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            GetComponent<Rigidbody2D>().simulated = true;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            transform.localEulerAngles = new Vector3(0, 0, Random.Range(minAngle, maxAngle));
            Invoke("push", 0.1f);
            Invoke("killBullet", DeathTime);
            #endregion
        }
    }
    void push()
    {
        GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(LaunchForce, 0));
    }
    void SpawnBullet()
    {
        Instantiate(gameObject);


    }
    void Update()
    {
        if (name == "Source")
        {
            #region Source behaviors
            //source behaviors
            #endregion
        }
        else
        {
            #region Other bullet behaviors
            //other behaviors
            #endregion
        }
    }
    void killBullet()
    {
        Destroy(gameObject);
    }
}
