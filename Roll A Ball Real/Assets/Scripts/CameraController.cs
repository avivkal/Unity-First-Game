using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position; //ofset = difference between camera and player
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset; // set the camera position to the player position plus the starting point
    }
}