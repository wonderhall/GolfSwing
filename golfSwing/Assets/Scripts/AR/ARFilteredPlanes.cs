using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARFilteredPlanes : MonoBehaviour
{

    [SerializeField] private Vector2 dimensionForBigPane;

    public event Action OnVerticalFound;
    public event Action OnHorizontalFound;
    public event Action OnBigPlaneFound;

    private ARPlaneManager arPlaneManager;

    private List<ARPlane> arPlanes;

    private void OnEnable()
    {
        arPlanes = new List<ARPlane>();
        arPlaneManager = FindObjectOfType<ARPlaneManager>();
        arPlaneManager.planesChanged += OnPlanesChanged;
    }

    private void OnDisable()
    {
        arPlaneManager.planesChanged -= OnPlanesChanged;
    }

    private void OnPlanesChanged(ARPlanesChangedEventArgs args)
    {
        if (args.added != null && args.added.Count > 0)
            arPlanes.AddRange(args.added);

        foreach(ARPlane plane in arPlanes.Where(Plane => Plane.extents.x * Plane.extents.y >= 0.1f))
        {
            if (plane.alignment.IsVertical())
            {
                OnVerticalFound.Invoke();
            }
            else
            {
                OnHorizontalFound.Invoke();
            }

            if(plane.extents.x * plane.extents.y >= dimensionForBigPane.x * dimensionForBigPane.y)
            {
                OnBigPlaneFound.Invoke();
            }
        }
    }

}
