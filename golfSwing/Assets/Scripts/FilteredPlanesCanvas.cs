using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilteredPlanesCanvas : MonoBehaviour
{
    [SerializeField] private Toggle verticalPlaneToggle;
    [SerializeField] private Toggle horizontalPlaneToggle;
    [SerializeField] private Toggle bigPlaneToggle;
    [SerializeField] private Button startButton;

    private ARFilteredPlanes aRFilteredPlanes;

    public bool VerticalPlaneToggel
    {
        get => verticalPlaneToggle.isOn;
        set
        {
            verticalPlaneToggle.isOn = value;
            CheckItAllAreTrue();
        }
    }

    public bool HorizontalPlaneToggel
    {
        get => horizontalPlaneToggle.isOn;
        set
        {
            horizontalPlaneToggle.isOn = value;
            CheckItAllAreTrue();
        }
    }

    public bool BigPlaneToggel
    {
        get => bigPlaneToggle.isOn;
        set
        {
            bigPlaneToggle.isOn = value;
            CheckItAllAreTrue();
        }
    }
    private void OnEnable()
    {
        aRFilteredPlanes = FindObjectOfType<ARFilteredPlanes>(); 

        aRFilteredPlanes.OnVerticalFound += () => VerticalPlaneToggel = true;
        aRFilteredPlanes.OnHorizontalFound += () =>HorizontalPlaneToggel = true;
        aRFilteredPlanes.OnBigPlaneFound += () =>BigPlaneToggel= true;
    }

    private void OnDisable()
    {
        aRFilteredPlanes.OnVerticalFound -= () => VerticalPlaneToggel = true;
        aRFilteredPlanes.OnHorizontalFound -= () => HorizontalPlaneToggel = true;
        aRFilteredPlanes.OnBigPlaneFound -= () => BigPlaneToggel = true;
    }

    private void CheckItAllAreTrue()
    {
        if (verticalPlaneToggle && HorizontalPlaneToggel && BigPlaneToggel)
            startButton.interactable = true;
    }
}
