using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;

    private void Update()
    {
        transform.Translate(_direction * Time.deltaTime);       
    }
}
