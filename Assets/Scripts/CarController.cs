using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CarController : MonoBehaviour
{
    [SerializeField] private float value;
    [SerializeField] private float speed;
    [SerializeField] private float maxMov;
    [SerializeField] private float minMov;
    private Vector2 targetPos;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject[] disableObject;

    private void Start() {
        targetPos = transform.position;
    }
    
    private void Update() {
        transform.position = Vector2.MoveTowards(transform.position,targetPos,speed*Time.deltaTime);
        if((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && transform.position.x<maxMov){
            targetPos = new Vector2(transform.position.x + value, transform.position.y);
        }
        else if((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && transform.position.x>minMov){
            targetPos = new Vector2(transform.position.x - value, transform.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "Car"){
            Debug.Log("PlayerDied");
            Destroy(gameObject);
            gameOver.SetActive(true);
            for (int i=0; i<disableObject.Length; i++){
                disableObject[i].SetActive(false);
            }
        }
    }
}
