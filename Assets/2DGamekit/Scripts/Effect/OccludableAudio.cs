using UnityEngine;

namespace Gamekit2D
{
    // C#
    public class OccludableAudio : MonoBehaviour
    {
        private Transform m_MyTrans;
        private AudioSource m_Source;
     
        private float m_MaxDistance;

        public float m_Target;
        
        public Transform Listener;
        public float OccludedDistance = 5.0f;
        public float FadeSpeed = 10.0f;
        public LayerMask Mask;
     
        void Start()
        {
            m_MyTrans = transform;
            m_Source = GetComponent<AudioSource>();
            m_MaxDistance = m_Source.maxDistance;
        }
        void Update()
        {
            float target;
            if (Physics.Linecast(Listener.position, m_MyTrans.position, Mask.value))
                target = OccludedDistance;
            else
                target = m_MaxDistance;
            m_Source.maxDistance = Mathf.MoveTowards(m_Source.maxDistance, m_Target, Time.deltaTime * FadeSpeed);
        }
    }

}