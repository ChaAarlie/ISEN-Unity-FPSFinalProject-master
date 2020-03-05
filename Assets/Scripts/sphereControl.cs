using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereControl : MonoBehaviour
{
    private GameObject player;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(
            Random.Range(-49f, 40f),
            Random.Range(5.5f, 8f),
            Random.Range(-38f, 48f)
        );
    }

    private static Quaternion GetRandomRotation()
    {
        return Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLISION");
        if (other.gameObject.layer == 9) 
        {
            Destroy(gameObject);
        }
        
    }
}
