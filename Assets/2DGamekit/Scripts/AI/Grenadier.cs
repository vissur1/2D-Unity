using System.Collections;
using System.Collections.Generic;
using BTAI;
using Gamekit2D;
using UnityEngine;

public class Grenadier : MonoBehaviour {

    [SerializeField]
    //Rigidbody2D bullet;

    public Grenade grenade;

    public Vector2 grenadeLaunchVelocity;
	
    float fireRate;
    float nextFire;

    public Transform target;
    public int speed;
    public Transform grenadeSpawnPoint;

	
    // Use this for initialization
    void Start () {
        fireRate = 3f;
        nextFire = Time.time;
        //script = GetComponent(Monster);
        //script.enable = false;
        //gameObject.SetActive(false);
        nextFire = 5;

    }
	
    // Update is called once per frame
    void Update () {
		
        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation,  speed * Time.deltaTime);
        direction = transform.position;
		
		
        float targetX = target.position.x;
        float targetY = target.position.y;

		
        CheckIfTimeToFire (direction, targetX, targetY);
		

    }

    void CheckIfTimeToFire(Vector2 direction, float targetX, float targetY)
    {
        if (Time.time > nextFire)
        {

	        ThrowGrenade(direction, targetX, targetY);
	        
            nextFire = Time.time + fireRate;
        }
		
    }
    
    void ThrowGrenade(Vector2 direction, float targetX, float targetY)
    {

	    grenadeLaunchVelocity = new Vector2(targetX - grenadeSpawnPoint.position.x, targetY - grenadeSpawnPoint.position.y + 5) * 75;
	    
	    var p = Instantiate(grenade);
	    p.transform.position = grenadeSpawnPoint.position;
	    p.initialForce = grenadeLaunchVelocity;
	    
	    var d = Instantiate(grenade);

	    grenadeLaunchVelocity = new Vector2(targetX - grenadeSpawnPoint.position.x, targetY - grenadeSpawnPoint.position.y + 6) * 75;
	    
	    d.transform.position = grenadeSpawnPoint.position;
	    d.initialForce = grenadeLaunchVelocity;
	    
	    
	    grenadeLaunchVelocity = new Vector2(targetX - grenadeSpawnPoint.position.x, targetY - grenadeSpawnPoint.position.y + 4) * 75;
	    
	    var c = Instantiate(grenade);
	    c.transform.position = grenadeSpawnPoint.position;
	    c.initialForce = grenadeLaunchVelocity;
    }
    
}


