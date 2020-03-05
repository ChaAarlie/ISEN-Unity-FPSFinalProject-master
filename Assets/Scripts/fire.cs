using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public List<GameObject> bullets;
    [SerializeField] private GameObject prefab;
    [SerializeField] private Camera myCam;
    Rigidbody rb;
    int firerate = 30;
    int buffer=0;

    public float speed = 150;

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
        rb = prefab.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))  // instentiate a new GameObject each time M1 is pressed 
        {
            GameObject instantiatedProjectile = Instantiate(prefab,
                                                           transform.position,
                                                           transform.rotation) 
                as GameObject;
            bullets.Add(instantiatedProjectile);
            instantiatedProjectile.GetComponent<Rigidbody>().velocity = myCam.transform.TransformDirection(Vector3.forward) * 100;
        }

        if (Input.GetButtonDown("Fire2"))   // M2 to destroy all GameObjects "bullets" created 
        {
            foreach (var nextBullet in bullets)
            {
                Destroy(nextBullet);
            }
            bullets.Clear();
        }
        if (Input.GetMouseButton(0))
        {
            buffer++;
            if (buffer > firerate)
            {
                GameObject instantiatedProjectile = Instantiate(prefab,
                                                               transform.position,
                                                               transform.rotation)
                    as GameObject;
                bullets.Add(instantiatedProjectile);
                instantiatedProjectile.GetComponent<Rigidbody>().velocity = myCam.transform.TransformDirection(Vector3.forward) * 100;
                buffer = 0;
            }
        }
    }
    
}
