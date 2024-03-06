using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Vector3 _eulers;

    private void Update()
    {
        transform.Rotate(_eulers * Time.deltaTime);
    }
}
