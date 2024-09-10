using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CameraMove();
    }

    public void CameraMove() 
    {
        transform.position = new Vector3(playerTransform.position.x, 4.5f, playerTransform.position.z+0.5f);
    }
}
