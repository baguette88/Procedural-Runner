using System.Collections;

using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public static int playerSpeed = 10;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.right * playerSpeed * Time.fixedDeltaTime);
    }
}
