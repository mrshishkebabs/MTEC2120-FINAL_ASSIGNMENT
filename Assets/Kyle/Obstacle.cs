using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform SpawnPoint;

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("Obstacle OnCollisionEnter");
        if (coll.gameObject.tag == "Player")

        {

            Debug.Log("Respawn Player");

            Player.transform.position = SpawnPoint.transform.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Obstacle OnTriggerEnter");

        if (other.gameObject.tag == "Player")

        {
            Debug.Log("Respawn Player " + SpawnPoint.transform.position);
            Player.gameObject.GetComponent<CharacterController>().enabled = false;
            Player.gameObject.SetActive(false); 
            Player.transform.position = SpawnPoint.transform.position;
            Player.gameObject.SetActive(true);
            Player.gameObject.GetComponent<CharacterController>().enabled = true;


        }
    }

}

