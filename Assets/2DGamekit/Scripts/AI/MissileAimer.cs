using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using Gamekit2D;
using UnityEngine;

public class MissileAimer : MonoBehaviour
{

    public float speed = 5f;

    public Transform target;

    
    private void Update()
    {
        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 180;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation,  speed * Time.deltaTime);
        
    }
    
    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }
    */

   /* IEnumerator Start()
    {
    
        ShootBullet();
        yield return new WaitForSeconds(4);

    }

    void ShootBullet()
    {
        Instantiate(bullet,transform.position, transform.rotation);

    }*/

    // Update is called once per frame

}
