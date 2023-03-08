using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownShooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
           Shoot();
        }
        
    }

    void Shoot(){
      GameObject clone = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
      Destroy(clone, 10f);
    }
}
