using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    [SerializeField]
    private GameObject decalprefab;
    [SerializeField]
    private bool candraw;
    [SerializeField]
    private ResultsScreen result;
    void Update()
    {
       
        Vector3 markerRange = transform.TransformDirection(Vector3.right) ;
        RaycastHit hit;

       

        if (Physics.Raycast(transform.position, markerRange, out hit, 0.1f) && candraw == true)
        {
            SpawnDecal(hit);
            candraw = false;
            checkTMark CheckT = hit.collider.gameObject.transform.root.GetComponent<checkTMark>();
            if (CheckT != null)
            {
                Check(hit);
            }
        }
        
        if(hit.collider == null)
        {
            candraw = true;
        }
    }
    
    private void SpawnDecal(RaycastHit hit)
    {
        var decal = Instantiate(decalprefab);
        decal.transform.position = hit.point;
        decal.transform.forward = hit.normal * -1f;
    }
    public void Check(RaycastHit hit)
    {
        Debug.Log(hit.transform.root + " T mark registered hit by " + transform.name);
        if(transform.name == "PR_RedMarker")
        {
            result.TRedMarkText(hit);
        }
    }
}

