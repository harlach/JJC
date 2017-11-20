
using UnityEngine;

public class cameraFollowPlayer : MonoBehaviour {

    public Transform Knight;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        transform.position = Knight.position + offset;
	}
}
