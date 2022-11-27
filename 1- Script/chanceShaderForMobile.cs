using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chanceShaderForMobile : MonoBehaviour
{

    Renderer[] rend;
    // Start is called before the first frame update
    void Awake()
    {
        if (Application.isMobilePlatform)
        {
            rend = transform.GetComponentsInChildren<Renderer>();

            for (int i = 0; i < rend.Length; i++)
            {
                if (rend[i].material.shader == Shader.Find("Mobile/Diffuse") /*|| rend[i].material.shader == Shader.Find("Standard")*/)
                {
                    rend[i].material.shader = Shader.Find("Unlit/Texture");
                }
            }
        }
    }


}
