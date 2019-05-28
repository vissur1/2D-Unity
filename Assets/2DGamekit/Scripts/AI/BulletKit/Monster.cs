using System.Collections;
using System.Collections.Generic;
using BTAI;
using UnityEngine;

public class Monster : MonoBehaviour {

	[SerializeField]
	//Rigidbody2D bullet;

	Rigidbody2D projectile;

	
	
	float fireRate;
	float nextFire;

	public Transform target;
	public int speed;
	public Transform spawnposition;

	
	// Use this for initialization
	void Start () {
		fireRate = 3f;
		nextFire = Time.time;
		//script = GetComponent(Monster);
		//script.enable = false;
		//gameObject.SetActive(false);
		nextFire = 7;

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
			Rigidbody2D clone;
			//clone = Instantiate(projectile, transform.position, transform.rotation);

			clone = Instantiate(projectile);

			clone.transform.position = new Vector2(spawnposition.position.x, spawnposition.position.y);
			
			targetX = target.position.x;
			targetY = target.position.y;
			
			
			clone.velocity = new Vector2(targetX - spawnposition.position.x + Random.Range(-1, 1), targetY - spawnposition.position.y + 1 + Random.Range(-1, 1));

			nextFire = Time.time + fireRate;
		}
		
	}

}
