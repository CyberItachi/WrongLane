using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    private float waitTime;
    [SerializeField] private GameObject tree;
    [SerializeField] private float starttime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(waitTime<=0){
            Instantiate(tree, new Vector2(UnityEngine.Random.Range(6f,8f), transform.position.y), quaternion.identity);
            waitTime = starttime;
        }
        else waitTime -= Time.deltaTime;
    }
}
