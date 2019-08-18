
using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    public float cameraSpeed = 5.0f;
    //cam speed

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 camPos = transform.position;
        camPos.x = player.transform.position.x - -9.0f;
        transform.position = Vector3.Lerp (transform.position, camPos, 3 * Time.fixedDeltaTime);

        //Y position follow below
        camPos.y = player.transform.position.y + 2;
        transform.position = Vector3.Lerp (transform.position, camPos, 7.0f * Time.fixedDeltaTime);

        if (Gameinit.gameIsPlaying == false)
		{
			camPos.x = player.transform.position.x - 0.0f;
			transform.position = camPos;
            //delay after death
		}
	}
}

