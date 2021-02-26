using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private float counter;
    private float dist;

    public Transform origin;
    public Transform destination;


    public float mWidth = 0.05f;


    //private GameObject Pscale;
    //public float lineDrawSpeed = 6f;


    // Start is called before the first frame update
    void Start()
    {
        //Pscale = GameObject.Find("golferPrefab");


        lineRenderer = GetComponent<LineRenderer>();
        //       lineRenderer.SetPosition(0, origin.position);
        //       lineRenderer.SetPosition(1, destination.position);
        lineRenderer.SetWidth(mWidth, mWidth);


    }

    // Update is called once per frame
    void Update()
    {
        

        transform.position = new Vector3();
        transform.rotation = Quaternion.identity;

        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetPosition(1, destination.position);

        //mWidth = (mWidth) * (Pscale.transform.localScale.x);
        //lineRenderer.SetWidth(mWidth, mWidth);

    }
}
