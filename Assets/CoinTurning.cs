using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTurning : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    public void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
