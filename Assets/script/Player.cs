using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    private PlayerCamera Pcamera;
    private Vector3 ScreenCenter;
    public static float hitcount = 0;
    public static float Accuracycount = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScreenCenter = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        Pcamera = GetComponent<PlayerCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCamera();
        Shoot();
    }
    
    void UpdateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Pcamera.UpdateRotate(mouseX, mouseY);
    }
    void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        { 
            RaycastHit hit;
            Ray ray = Camera.main.ViewportPointToRay(Vector2.one * 0.5f);
            

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.name == "target(Clone)")
                {
                    Destroy(hit.transform.gameObject);
                    hitcount++;

                }
                else
                {
                    if(hitcount > 0)
                    {
                        hitcount--;
                    }
                    
                }


                if (hitcount <= 0)
                {
                    Accuracycount = 0;
                }
                else
                {
                    Accuracycount = (hitcount / TargetSpawn.TargetNum)*100;
                }

            }
            
        }
    }
}
