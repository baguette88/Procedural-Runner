using UnityEngine;

public class Player_Col : MonoBehaviour
{  public GameObject restartUI;
    public GameObject jetPack;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
            PlayerDies();
        Debug.Log("Player trigger Enemy tag");
    }
    //ABOVE HAS BEEN REPLACED (OBSOLETE?)

    void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.tag == "Coin")
            DataManagement.datamanagement.coinsCollected++;
            DataManagement.datamanagement.currentScore++;
            Destroy(trig.gameObject);
        //increase score
        //increase coin collection
        //play audio effect!!!!!

    }
    //on player Death Below
    void PlayerDies()
    {
        DataManagement.datamanagement.SaveData();
        Destroy(jetPack);
        restartUI.gameObject.SetActive(true);
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<PlayerControls>().enabled = false;
        GetComponent<ParticleSystem>().Play();
        GetComponent<PlayerMove>().enabled = false;
        //UI for restarting
    }
}

//Xplay death audio
//Xsave score
//Xactivate UI for restarting game



//[System.Obsolete]


//[System.Obsolete]
//void PlayerDies()
//{
// Application.LoadLevel("Main");
//}


