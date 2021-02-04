using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testInstane_Prefab : MonoBehaviour
{

    public GameObject prefabToPlace;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(prefabToPlace);
        var clone = Instantiate(prefabToPlace);
        clone.name = "golferPrefab";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(GameObject.Find("golferPrefab"));
        }
    }
}
