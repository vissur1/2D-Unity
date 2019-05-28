using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;

namespace Gamekit2D
{
    public class TargetingProjectile : MonoBehaviour
    {
        public Vector2 initialForce;
        public float timer = 100;
        public float fuse = 0.01f;
        public GameObject explosion;
        public float explosionTimer = 3;
        new Rigidbody2D rigidbody;

        public Transform target;

        protected GameObject m_HitEffect;

        
        float moveSpeed = 7f;

        Rigidbody2D rb;

        Vector2 moveDirection;
        
        void OnEnable()
        {
            
            //Vector3 playerPos = new Vector3(target.position.x, target.position.y + 1, target.position.z);

// Aim bullet in player's direction.
            //transform.rotation = Quaternion.LookRotation(playerPos);

 
            //transform.LookAt(target.position);
            
            //transform.right = target.position - transform.position;
            //transform.LookAt(target);


            
            rigidbody = GetComponent<Rigidbody2D>();
            Destroy(gameObject, timer);

            m_HitEffect = Instantiate(explosion);
            m_HitEffect.SetActive(false);
        }

        public void Destroy()
        {
            m_HitEffect.transform.position = transform.position;
            m_HitEffect.SetActive(true);
            GameObject.Destroy(m_HitEffect, explosionTimer);
            Destroy(gameObject);
        }

        void Start()
        {
           // rigidbody.AddForce(initialForce);
        }
    }
}