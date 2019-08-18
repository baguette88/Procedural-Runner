using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        adjustFuelBar();
    }

    void adjustFuelBar()
    {
        if (PlayerControls.jetPackFuel > 0.0001)
        {
            gameObject.transform.localScale = new Vector3(PlayerControls.jetPackFuel, 1, 1);
        }
    }
}
