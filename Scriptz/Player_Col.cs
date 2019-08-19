using UnityEngine;
using System.Collections;

public class Player_Col : MonoBehaviour
{

    public GameObject restartUI;
    public GameObject jetPack;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            PlayerDies();
        }
    }

    void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.tag == "Coin")
        {
            DataManagement.datamanagement.coinsCollected++;
            DataManagement.datamanagement.currentScore++;
            Destroy(trig.gameObject);
        }
    }

    void PlayerDies()
    {
        DataManagement.datamanagement.SaveData();
        Destroy(jetPack);
        restartUI.gameObject.SetActive(true);
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<PlayerControls>().enabled = false;
        GetComponent<PlayerMove>().enabled = false;
        GetComponent<ParticleSystem>().Play();
        Gameinit.gameIsPlaying = false;
    }

}