using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public float desiredYCoordinate;
    public int requiredCollectables;
    bool movedYet = false;

    void Update()
    {
        if (movedYet == false)
        {
            if (GameObject.Find("player").GetComponent<PlayerMovement>().count == requiredCollectables)
            {
                transform.Translate(new Vector3(1f, 0f, 0f) * 2 * Time.deltaTime);
            }
            if (transform.position.y < desiredYCoordinate)
            {
                movedYet = true;
            }
        }
    }   
}
