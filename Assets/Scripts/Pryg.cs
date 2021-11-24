using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pryg : MonoBehaviour
{
    public int power;
    Vector3 direction = new Vector3(-10, 0, 0);
    public void Pryzhok()
    {
        GetComponent<Rigidbody>().AddForce(direction * power, ForceMode.Impulse);
    }
}
