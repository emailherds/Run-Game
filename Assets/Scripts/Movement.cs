using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = new Vector3();
        if (Input.GetKeyDown(KeyCode.A))
        {
            a = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            a = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= 2 && transform.position.x >= -2)
            transform.Translate(Vector3.MoveTowards(transform.position,a,5f*Time.deltaTime));
    }

}