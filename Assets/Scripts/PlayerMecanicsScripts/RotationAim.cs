using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RotationAim : MonoBehaviour
{
    void Update()
    {
        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angulo = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angulo - 90, Vector3.forward);
        transform.rotation = rotation;
    }
}
