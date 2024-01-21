using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]
    public static float camXspeed = 1f;
    [SerializeField]
    public static float camYspeed = 1f;

    private float MinX = -50;
    private float MaxX = 20;
    private float MinY = -50;
    private float MaxY = 50;
    private float eulerAngleX;
    private float eulerAngleY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateRotate(float mouseX, float mouseY)
    {
        eulerAngleY += mouseX * camYspeed;
        eulerAngleX -= mouseY * camXspeed;

        eulerAngleX = ClampAngleX(eulerAngleX,MinX,MaxX);
        eulerAngleY = ClampAngleY(eulerAngleY,MinY,MaxY);

        transform.rotation = Quaternion.Euler(eulerAngleX, eulerAngleY, 0);
    }

    private float ClampAngleX(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
    private float ClampAngleY(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
