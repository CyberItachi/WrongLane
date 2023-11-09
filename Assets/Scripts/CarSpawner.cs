using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private float minStartTIme;
    [SerializeField] private float MaxStartTime;
    [SerializeField] public GameObject[] cars;
    private float waitTime;
    private void Update() {
        
        if(waitTime<=0){
        int random = UnityEngine.Random.Range(0,cars.Length);
        Instantiate(cars[random],transform.position, quaternion.identity);
        waitTime = UnityEngine.Random.Range(minStartTIme,MaxStartTime);
        }
        else{
            waitTime -= Time.deltaTime;
        }
        if(Time.time>5f && Time.time<10){
            minStartTIme = .8f;
            MaxStartTime = 1f;
        }
        else if(Time.time>10f && Time.time<20f){
            minStartTIme = .6f;
            MaxStartTime = .8f;
        }
        else if(Time.time>20f && Time.time<30f){
            minStartTIme = .6f;
            MaxStartTime = .6f;
        }
        else if(Time.time>30f && Time.time<40f){
            minStartTIme = .5f;
            MaxStartTime = .8f;
        }
        else if(Time.time>40f && Time.time<50f){
            minStartTIme = .5f;
            MaxStartTime = .6f;
        }
    }
}
