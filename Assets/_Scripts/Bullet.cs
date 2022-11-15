using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    PlayerStats playerStat;
    private void Awake()
    {
        playerStat = PlayerManager.instance.player.GetComponent<PlayerStats>();
    }

    private void OnCollisionEnter(Collision other)
    {
        //Destroy(gameObject);

        gameObject.SetActive(false);

        if(other.collider.tag == "Player")
        {
            playerStat.TakeDamage(playerStat.damage);

        }
        else if (other.collider.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
