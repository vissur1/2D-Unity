using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    [RequireComponent(typeof(Damager))]


    public class Missile : MonoBehaviour
    {

        public Transform target;

        public void Destroy()
        {
            Destroy(gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            /*
            Vector3 playerPos = new Vector3(target.position.x, target.position.y + 1, target.position.z);
     
            // Aim bullet in player's direction.
            transform.rotation = Quaternion.LookRotation(playerPos);
            */
            //rigidbody = GetComponent<Rigidbody2D>();

            transform.LookAt(target.position);


        }

        // Update is called once per frame
        void Update()
        {
            transform.position += transform.forward * 7 * Time.deltaTime;

        }

        public void OnHitNonDamageable(Damager origin)
        {

            Destroy(gameObject);
            transform.LookAt(target.position);


        }
    }
}