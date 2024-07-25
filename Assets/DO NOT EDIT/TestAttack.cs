using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAttack : MonoBehaviour
{
    //This is the holder of the bullet script
    public GameObject spawner;

    //This is the object of the bullet, it can just be
    //the sprite or it can have behavior of it's own
    public GameObject bullet;

    public float timer = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            Attack();
            timer = 0;
        }
    }
    
    private void Attack()
    {
        for (int i = 0; i < 8; i++)
        {
            //bullet: the thing that is spawned as mentioned above
            //spawner.transform.position: this is the location the bullet is spawned at, you can give an existing
            //objects location or you can just but in a Vector3
            //i * 45: the rotation given to the object
            //10: the velocity given to the object in the direction of the previous angle
            spawner.GetComponent<BulletBase>().shootBullet(bullet, spawner.transform.position, i * 45, 10);
        }
    }
}
