using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartGame : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
     {
        //When R is pressed the room is reset
         if(Input.GetKeyDown(KeyCode.R))
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
