using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialACTtrans : MonoBehaviour {

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "transitionAct1")
        {
            SceneManager.LoadScene("TutorialtoAct1");
        }
    }
}
