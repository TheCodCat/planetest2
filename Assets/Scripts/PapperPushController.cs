using System;
using UnityEngine;

public class PapperPushController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private PointPapper pointPapper;
    [SerializeField] private Vector3 offset;
    private const string ISPUSH_KEY = "IsUpped";
    public void ChangeState(bool value)
    {
        Debug.Log(value);
        animator.SetBool(ISPUSH_KEY, value);
    }

    private void FixedUpdate()
    {
        lineRenderer.SetPosition(0, pointPapper.point1.position);
        lineRenderer.SetPosition(1, pointPapper.point2.position + offset);
        lineRenderer.SetPosition(2, pointPapper.point2.position);
    }
}

[Serializable]
public class PointPapper
{
    public Transform point1;
    public Transform point2;
}
