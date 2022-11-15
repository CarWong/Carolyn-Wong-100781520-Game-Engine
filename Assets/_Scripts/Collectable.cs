using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int score;
    public int heal;
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Player")
        {
            if (score != 0)
            {
                ScoreManager.instance.ChangeScore(score);
            }
            else if (heal != 0)
            {
                PlayerManager.instance.player.GetComponent<CharacterStats>().RecoverHealth(heal);

            }
            Destroy(gameObject);
        }
    }
}
