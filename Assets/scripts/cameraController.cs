using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    Vector3 offset = new Vector3(81.359f, -7.141f, -0.22f);

    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

    }
}

