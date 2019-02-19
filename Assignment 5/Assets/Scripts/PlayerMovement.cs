using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpHeight = 250;

    public int count;
    public Text countText;

    private void Start()
    {
        count = 0;
        SetCountText();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
  

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(transform.up * jumpHeight);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.TransformPoint(Vector3.zero);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            count += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

}
