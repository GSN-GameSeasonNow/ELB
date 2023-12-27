using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Del_obj : MonoBehaviour
{
    public GameObject del_Canv;
    void Update()
    {
        Destroy(del_Canv,7f);
    }
}
