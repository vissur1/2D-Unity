using BTAI;
using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Gamekit2D
{
    public class SpotlightController : MonoBehaviour
    {
        public Light L2;
        public Light R2;

        public Light L1;
        public Light R1;

        public Light M0;

        private float i = 0;
        private float j = 0;
        private float k = 0;

        public float decreaseAmount;

        private float change = 0;

        private float decreaseAmountI;
        private float decreaseAmountJ;
        private float decreaseAmountK;

        public GameObject otherobj;//your other object
        public string scr;// your secound script name




        void Start()
        {

        decreaseAmountI = decreaseAmount - 1;
        decreaseAmountJ = decreaseAmount;
        decreaseAmountK = decreaseAmount + 1;

        change = decreaseAmount / 5;

        }


        private void Update()
        {
            if (i != decreaseAmountI)
            {
                L2.intensity = L2.intensity - change;
                R2.intensity = R2.intensity - change;

                i = i + change;
            }
            
            else if (j != decreaseAmountJ)
            {
                L1.intensity = L1.intensity - change;
                R1.intensity = R1.intensity - change;

                j = j + change;
            }
            
            else if (k != decreaseAmountK)
            {
                M0.intensity = M0.intensity - change;


                k = k + change;
            }

            else
            {
                Stop();
            }
        }

        IEnumerator Wait()
        {
            print(Time.time);
            yield return new WaitForSecondsRealtime(i);
            print(Time.time);
        }

        void Stop()
        {
            decreaseAmountI = 0;
            decreaseAmountJ = 0;
            decreaseAmountK = 0;
        }
    }
}