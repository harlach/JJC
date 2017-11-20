using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    // Use this for initialization
    //void Start () {

    //}

    // Update is called once per frame
    //void Update () {

    //}

    public void newGameButton(string tutorial)
    {
        SceneManager.LoadScene(tutorial);
    }

    public void exitGameButton()
    {
        //Debug.Log("User has quit game!");
        Application.Quit();
    }

}
