using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class AgRuTest : MonoBehaviour
{
    [DllImport("__Internal")]
    public static extern void AgRuAuth();
    [DllImport("__Internal")]
    public static extern string ImJohnny();

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AgRuAuth();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log(ImJohnny());
        }
    }
}
