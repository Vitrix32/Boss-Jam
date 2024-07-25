using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBase : MonoBehaviour
{
    public void shootBullet(GameObject bullet, Vector3 shotLocation, float shotAngle, float shotForce)
    {
        GameObject b = Instantiate(bullet, shotLocation, Quaternion.Euler(0, 0, -shotAngle));
        Rigidbody2D rb = b.GetComponent<Rigidbody2D>();
        rb.velocity = shotForce * b.transform.up;
    }
}
