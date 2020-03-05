using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereSpawn : MonoBehaviour
{
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject player;
    public static int timer =180 ;
    private static int time = 0;
    public static int lvl = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnSphere();
    }

    private void spawnSphere() 
    {
        time++;
        if (time > 180)
        {
            Vector3 posRand = GetRandomPosition();
            Quaternion rotRand = GetRandomRotation();
            if (Vector3.Distance(posRand, player.transform.position) > 20 )
            {
                GameObject instCrown = Instantiate(sphere, posRand, rotRand)
                            as GameObject;
                time = 0;
            }
        }
    }
    private Vector3 GetRandomPosition()
    {
        return new Vector3(
            Random.Range(-49f, 40f),
            Random.Range(5.5f, 32f),
            Random.Range(-38f, 48f)
        );
    }

    private static Quaternion GetRandomRotation()
    {
        return Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
    }
}
