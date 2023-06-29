using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCoinClicked : MonoBehaviour
{

    private Material _material;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    public void HandleClick()
    {
        Color color = new Color(Random.value, Random.value, Random.value);
        _material.color= color;
    }
}
