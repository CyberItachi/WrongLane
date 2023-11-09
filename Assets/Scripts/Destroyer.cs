using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour
{
    private int pScore = 0;
    public TMP_Text score;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.parent.tag == "obstacle"){
            pScore += 1;
            score.text = pScore.ToString();
        }
        Destroy(other.gameObject);
        Destroy(other.transform.parent.gameObject);
    }
}
