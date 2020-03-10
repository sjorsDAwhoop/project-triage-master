using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    private int Size = 2;
    Material mat;

    void Start()
    {
        
    }

    void Update()
    {
        
        Vector3 markerRange = transform.TransformDirection(Vector3.forward) ;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, markerRange ,out hit, 0.1f))
        {
            Renderer rend = hit.transform.GetComponent<Renderer>();
            MeshCollider meshCollider = hit.collider as MeshCollider;

            Texture2D tex = rend.material.mainTexture as Texture2D;
            Vector2 pixelUV = hit.textureCoord;
            pixelUV.x *= tex.width;
            pixelUV.y *= tex.height;

            for (int i = 0; i < Size; i++)
            {
                int x = (int)pixelUV.x;
                int y = (int)pixelUV.y;

                //Increment the X and Y
                x += i;
                y += i;

                //Apply
                tex.SetPixel(x, y, Color.red);

                //De-increment the X and Y
                x = (int)pixelUV.x;
                y = (int)pixelUV.y;

                x -= i;
                y -= i;

                //Apply
                tex.SetPixel(x, y, Color.red);
            }
            tex.Apply();
        }
        Debug.DrawRay(transform.position, markerRange, Color.blue);
    }

}

