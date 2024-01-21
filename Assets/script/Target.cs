using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Target : MonoBehaviour
{
    public static bool targetOn = false;
    public static float DestroyCycle = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targetOn == true)
        {
            StartCoroutine(DestroyTarget_Coroutine());
        }
    }
    IEnumerator DestroyTarget_Coroutine()
    {

        while (true)
        {
            yield return new WaitForSeconds(DestroyCycle);

            Destroy(gameObject);

        }
    }
}
