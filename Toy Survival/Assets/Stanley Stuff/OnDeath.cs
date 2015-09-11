using UnityEngine;
using System.Collections;

public class OnDeath : MonoBehaviour {

    private GameObject player;
    public GameObject playerCamera;
    public GameObject mainCamera;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player.name == "FPSController")
        {
            Debug.Log("Pleasepleaseplease");
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (player.GetComponent<PlayerHealth>().currentHealth <= 0)
        {
            playerCamera.SetActive(false);
            mainCamera.SetActive(true);
            Debug.Log("Is working");
        }
	}
}
