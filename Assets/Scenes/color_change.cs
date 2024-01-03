using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_change : MonoBehaviour
{
    
    bool isYellow;
    Color Red = new Color(255, 0, 0);
    Color Yellow = new Color(0, 255, 255);

    // Start is called before the first frame update
    void Start()
    {
        isYellow = true;
        GetComponent<Renderer>().material.color = Yellow;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isYellow)
            {
                GetComponent<Renderer>().material.color = Red;
                isYellow = false;
            }
            else
            {
                GetComponent<Renderer>().material.color = Yellow;
                isYellow = true;
            }
        }
    }

}
