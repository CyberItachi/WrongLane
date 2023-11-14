using TMPro;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private int pScore = 0;
    public TMP_Text score;

    private void Awake() {
        score.text = pScore.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.parent.tag == "obstacle"){
            pScore += 1;
            score.text = pScore.ToString();
        }
        Destroy(other.gameObject);
        Destroy(other.transform.parent.gameObject);
    }
}
