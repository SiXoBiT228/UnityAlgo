using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpFactor = 6.5f;
    
    void OnTriggerEnter(Collider other)
    {
        //Увеличение высоты прыжка игрока
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;
    }

    
    void OnTriggerExit(Collider other)
    {
        //Снижение высоты прыжка игрока
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;
    }
}

