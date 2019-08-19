using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour
{

    public static float jetPackFuel = 1.5f;
    public float jetPackForce = 10.0f;
    public GameObject jetPack;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && jetPackFuel >= 0.001f)
        {
            BoostUp();
            jetPack.GetComponent<ParticleSystem>().Play();
        }
        else
        {
            jetPack.GetComponent<ParticleSystem>().Stop();
        }
    }

    void BoostUp()
    {
        jetPackFuel = Mathf.MoveTowards(jetPackFuel, 0, Time.fixedDeltaTime);
        GetComponent<Rigidbody>().AddForce(new Vector3(0, jetPackForce));
    }

    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "Ground")
        {
            jetPackFuel = 1.5f;
        }
    }
}