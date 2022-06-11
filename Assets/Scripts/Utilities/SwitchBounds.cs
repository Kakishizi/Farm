using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SwitchBounds : MonoBehaviour
{
    private void Start()
    {
        SwitchConfinerShape();
    }
    private void SwitchConfinerShape()
    {
        PolygonCollider2D confinerShape = GameObject.FindGameObjectWithTag("BoundsConfiner").GetComponent<PolygonCollider2D>();
        CinemachineConfiner confiner = GetComponent<CinemachineConfiner>();
        confiner.m_BoundingShape2D = confinerShape;
        //Çå³ý»º´æ
        confiner.InvalidatePathCache();
    }
}
