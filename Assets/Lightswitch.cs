using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            if (light.color.ToString().Equals((new Color(0, 255, 0).ToString())))
                light.color = new Color(255, 0, 0);   
            else
            {
                light.color = new Color(0, 255, 0);

            }
        }
    }
}
