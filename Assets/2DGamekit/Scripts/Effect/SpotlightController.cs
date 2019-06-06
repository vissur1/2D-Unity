using BTAI;
using UnityEngine;
using System.Collections;

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


        private float decreaseAmountI = 4;
        private float decreaseAmountJ = 5;
        private float decreaseAmountK = 6;



        void Start()
        {

            /* for (float i = 0; i < decreaseAmount; i++)
            {
                L2.intensity = L2.intensity - 1;
                R2.intensity = R2.intensity - 1;


                
                //StartCoroutine(Wait((decreaseAmount - i)/decreaseAmount));
            }

            decreaseAmount++;

            for (float i = 0; i < decreaseAmount; i++)
            {
                L1.intensity = L1.intensity - 1;
                R1.intensity = R1.intensity - 1;
                

            }

            decreaseAmount++;

            for (float i = 0; i < decreaseAmount; i++)
            {
                M0.intensity = M0.intensity - 1;
                

            } */

        }

        private void Update()
        {
            if (i < decreaseAmountI)
            {
                L2.intensity = L2.intensity - 1;
                R2.intensity = R2.intensity - 1;

                i++;
            }
            
            else if (j < decreaseAmountJ)
            {
                L1.intensity = L1.intensity - 1;
                R1.intensity = R1.intensity - 1;

                j++;
            }
            
            else if (k < decreaseAmountK)
            {
                M0.intensity = M0.intensity - 1;


                k++;
            }
        }

        IEnumerator Wait()
        {
            print(Time.time);
            yield return new WaitForSecondsRealtime(i);
            print(Time.time);
        }
    }
}