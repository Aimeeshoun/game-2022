

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour

{

    public static int CoinValue = 100;




    void OnTriggerEnter()

    {

      //  Score1.score += CoinValue;

        Destroy(gameObject);

    }
}

