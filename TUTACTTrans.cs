using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TUTACTTrans : MonoBehaviour {

    // Use this for initialization
    //void Start () {

    //}

    // Update is called once per frame
    //void Update () {

    //}

    public void Button(string ACT1)
    {
        SceneManager.LoadScene(ACT1);
    }
}
