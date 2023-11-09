using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarBehave : MonoBehaviour
{
    private float speed = 10;
    private BoxCollider2D boxCol;
    private string eCarTag = "obstacle";

    private void Awake() {
        boxCol = gameObject.AddComponent<BoxCollider2D>();
        this.transform.parent.tag = eCarTag;
        this.transform.tag = "Car";
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y-speed*Time.deltaTime);
    }
}
