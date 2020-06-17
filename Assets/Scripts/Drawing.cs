using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    private int Size = 10;
    public GameObject marker;

    void Update()
    {
       
        Vector3 markerRange = transform.TransformDirection(Vector3.forward) ;
        RaycastHit hit;

        //draws pixels on texture with mesh collider

        if (Physics.Raycast(transform.position, markerRange ,out hit, 0.1f))
        {
            Renderer rend = hit.transform.GetComponent<Renderer>();
            MeshCollider meshCollider = hit.collider as MeshCollider;

            Texture2D tex = rend.material.mainTexture as Texture2D;
            Vector2 pixelUV = hit.textureCoord;
            pixelUV.x *= tex.width;
            pixelUV.y *= tex.height;

            //multiplies pixelsize by 10

            for (int i = 0; i < Size; i++)
            {
                int x = (int)pixelUV.x;
                int y = (int)pixelUV.y;

                
                 y += i;
                 x += i;

                //Apply
                tex.SetPixel(x, y, Color.red);

            }
            tex.Apply();
        }
        //shows range for marker
        Debug.DrawRay(transform.position, markerRange, Color.blue);
    }
    
}

