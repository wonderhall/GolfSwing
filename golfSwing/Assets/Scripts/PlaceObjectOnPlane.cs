using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
public class PlaceObjectOnPlane : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private Pose placementPose;
    private bool placementPoseIsValid;
    private bool isObjectPlaced;

    public GameObject positionIdidcator;
    public GameObject prefabToPlace;
    public Camera arCamera;
    ///////
    [SerializeField] private Button startButton;

    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }
    private void Update()
    {
        if (!isObjectPlaced)
        {

            UpdatedPlacementPose();

            if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                PlaceObject();
            }
        }
    }
    // Start is called before the first frame update
    private void UpdatedPlacementPose()
    {
        var screenCenter = arCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();

        raycastManager.Raycast(screenCenter, hits, TrackableType.All);

        placementPoseIsValid = hits.Count > 0;

        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose;
            var cameraForward = arCamera.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;

            placementPose.rotation = Quaternion.LookRotation(cameraBearing);
            positionIdidcator.SetActive(true);
            positionIdidcator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else
        {
            positionIdidcator.SetActive(false);
        }
    }

    private void PlaceObject()
    {

        var clone = Instantiate(prefabToPlace, placementPose.position, placementPose.rotation);
        clone.name = "golferPrefab";
        isObjectPlaced = true;
        positionIdidcator.SetActive(false);
        //스타트버튼활성화//
        startButton.interactable = true;
    }

    //뒤로가기 버튼을위해//
    public void FindPlace()
    {
        isObjectPlaced = false;
    }
}
