using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    public Transform LookAt;
    public float XOffset;
    public float YOffset;
    public float ZOffset;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = LookAt.transform.position + new Vector3(XOffset, YOffset, ZOffset);


    }
}
