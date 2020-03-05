using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("in collision bullet");
        Destroy(gameObject);
    }
}
