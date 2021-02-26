using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(next());
    }

    // Update is called once per frame
    IEnumerator next()
    {        //Print the time of when the function is first called.


        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(1);
        Debug.Log("loadScene");
        //After we have waited 5 seconds print the time again.
        //int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        //if (SceneManager.sceneCount > nextSceneIndex)
        //{
        //    SceneManager.LoadScene(nextSceneIndex);
        //}
    }
}