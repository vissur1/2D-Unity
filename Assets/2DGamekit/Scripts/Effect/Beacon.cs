using UnityEngine;

namespace Gamekit2D
{
    public class Beacon : MonoBehaviour
    {

	    public Light light;

	    public float FullRadius;

	    private float increaseOrDecrease = 2;
	    
	    void Start()
	    {
		
	    }
	    
        void Update ()
        {

	        light.range = light.range + increaseOrDecrease;

	        if (light.range == FullRadius)
	        {
		        increaseOrDecrease = -5;
	        }
	        
	        if (light.range == 0)
	        {
		        increaseOrDecrease = 0;

	        }




        }
    }
}