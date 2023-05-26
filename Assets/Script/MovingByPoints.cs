using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingByPoints : MonoBehaviour
{
    public float speed = 1f;
    public int pointIndex = 0;
    public float pointDistance = Mathf.Infinity;
    public Transform pointsHolder;
    public List<Transform> points;
    // Start is called before the first frame update
    void Start()
    {
        this.LoadPoints();
    }

    // Update is called once per frame
    void Update()
    {
        this.PointMoving();
    }

    private void FixedUpdate()
    {
        this.NextPointCalculate();
    }

    protected virtual void LoadPoints()
    {
        string name = transform.name + ("_Points");
        this.pointsHolder = GameObject.Find(name).transform;
        foreach(Transform point in this.pointsHolder)
        {
            this.points.Add(point);
        }
    }

    protected virtual void PointLerpMoving()
    {
        float lerpSpeed = 0.1f;
        Transform currentTranform = this.points[this.pointIndex];
        transform.position = Vector3.Lerp(transform.position, currentTranform.position, lerpSpeed);
    }

    protected virtual void PointMoving()
    {
        float step = this.speed * Time.deltaTime;
        Transform currentPoint = this.CurrentPoint();
        transform.position = Vector3.MoveTowards(transform.position, currentPoint.position, step);
    }

    protected virtual void NextPointCalculate()
    {
        this.pointDistance = Vector3.Distance(transform.position, this.CurrentPoint().position);
        if (this.pointDistance == 0) this.pointIndex++;
        if (this.pointIndex >= this.points.Count) this.pointIndex = 0;
    }

    public virtual Transform CurrentPoint()
    {
        return this.points[this.pointIndex];
    }
}
