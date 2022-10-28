using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Point : MonoBehaviour
{
    public bool Runtime = true;
    public Rigidbody2D rbd;
    public Vector2 PointID;
    public List<Bar> ConnectedBars;

    private void Start()
    {
        if (Runtime == false)
        {
            rbd.bodyType = RigidbodyType2D.Static;
            PointID = transform.position;
            if (GameManager.AllPoints.ContainsKey(PointID) == false) GameManager.AllPoints.Add(PointID, this);
        }
    }

    private void Update()
    {
        if(Runtime == false)
        {
            if(transform.hasChanged == true)
            {
                transform.hasChanged = false;
                transform.position = Vector3Int.RoundToInt(transform.position);
            }
        }
    }
}
