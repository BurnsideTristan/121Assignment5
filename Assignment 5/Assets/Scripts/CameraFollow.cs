using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Tutorial for camera: https://code.tutsplus.com/tutorials/unity3d-third-person-cameras--mobile-11230

    public GameObject target;
    Vector3 offset;

    private void Start()
    {
        offset = target.transform.position - transform.position;
    }
    private void Update()
    {
            float currentAngle = transform.eulerAngles.y;
            float desiredAngle = target.transform.eulerAngles.y;
            float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * 100);
            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            transform.position = target.transform.position - (rotation * offset);
            transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
            transform.LookAt(target.transform);

    }
} 
    
    
    
    /* public GameObject player;
    private Vector3 offset;
    private Vector3 firstPerson;
    bool isFirstPerson;

    private void Start()
    {
        offset = transform.position - player.transform.position;
        firstPerson = transform.position;
        isFirstPerson = false;
    }

    private void LateUpdate()
    {
        if (isFirstPerson) {
            transform.position = player.transform.position;
        }
        else
        {
            transform.position = player.transform.position + offset;
        }

        //transform.position = player.transform.position + offset;
        if (Input.GetKeyDown(KeyCode.F)){
            if(isFirstPerson == false)
            {
                isFirstPerson = true;
            }
            else
            {
                isFirstPerson = false;
            }
        }

    }*/



    /*public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void Update ()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = desiredPosition;

        transform.LookAt(target);
    }*/

