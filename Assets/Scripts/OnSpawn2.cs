using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class OnSpawn2 : MonoBehaviour
{
    public GameObject character;
    private bool canAdd = true;
    private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("Character");

        speed = speed + (Time.timeSinceLevelLoad / 5);
    }

    // Update is called once per frame
    void Update()
    {
        System.Random random = new System.Random();
        if (gameObject.transform.position.z + 12 <= character.transform.position.z)
            Destroy(gameObject);
        if (gameObject.transform.position.y < 4f)
        {
            if (gameObject.transform.position.y >= 0.5)
            {
                gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            else
            {
                Vector3 a = transform.position;
                a.y = 0.5f;
                transform.position = a;
            }
        }
        else if (gameObject.transform.position.y > 7.25f)
        {
            if (gameObject.transform.position.y <= 11.25)
            {
                gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else
            {
                Vector3 a = transform.position;
                a.y = 11.25f;
                transform.position = a;
            }
        }
    }
}
