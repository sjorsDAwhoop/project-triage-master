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

            Texture2D newTex = (Texture2D)GameObject.Instantiate(tex);
            newTex.SetPixels32(tex.GetPixels32());
      
           
              newTex.SetPixel(x, y, Color.red);
            newTex.Apply();
            Material newMaterial = new Material(rend.material.shader);
            newMaterial = rend.material;
            newMaterial.mainTexture = newTex;
            rend.material = newMaterial;
        }
        Debug.DrawRay(transform.position, markerRange, Color.blue);
    }

}

