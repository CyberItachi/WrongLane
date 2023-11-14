using UnityEngine;

public class TreeBehaviour : MonoBehaviour
{
   private float speed = 10;
    private BoxCollider2D boxCol;

    private void Awake() {
        boxCol = gameObject.AddComponent<BoxCollider2D>();
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y-speed*Time.deltaTime);
    }
}
