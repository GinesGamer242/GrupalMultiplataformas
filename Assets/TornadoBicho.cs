using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoBicho : MonoBehaviour
{
    private bool invert = false;
    private Vector3 prevPos;
    private Vector3 initialPos;
    private float offset;
    private float speed;

    private void Start()
    {
        initialPos = transform.position;

        invert = Random.value < 0.1f;

        transform.localScale = Vector3.one * Random.Range(0.2f, 1.0f);

        speed = Random.Range(0.9f, 1.3f);

        offset = Random.value;

        var renders = GetComponentsInChildren<Renderer>();
        renders[0].material.color = Random.ColorHSV();
        renders[1].material.color = Random.ColorHSV();
        renders[1].material.color = Random.ColorHSV();
    }
    private void Update()
    {
        prevPos = transform.position;

        Vector3 pos = Vector3.zero;

        pos.x = Mathf.Sin(speed*3.2457f*(invert ? Time.time : -Time.time) + offset*Mathf.PI*2) * initialPos.y + initialPos.x;
        pos.z = Mathf.Cos(speed*3.2365f*(invert ? Time.time : -Time.time) + offset * Mathf.PI*2) * initialPos.y + initialPos.z;

        pos.y = initialPos.y;

        transform.forward = pos - prevPos;

        transform.position = pos;
    }
}
