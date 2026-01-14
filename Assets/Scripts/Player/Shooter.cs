using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject m_Bullet;

    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.layer == 8)
            {
                GameManager.instance.bulletManager.DeployBullet(transform.position, transform.rotation);
            }
        }
#else
        if (Input.GetMouseButtonDown(0))
        {
            GameManager.instance.bulletManager.DeployBullet(transform.position, transform.rotation);
        }
#endif
    }
}
