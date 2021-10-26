using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.localScale += 0.5f * Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.localScale += 0.5f * Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.localScale += 0.5f * Vector3.up;
        }
    }
}
