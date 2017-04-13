using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Range(1, 100)] public float m_Speed;

	void Update ()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * m_Speed);
	}
}
