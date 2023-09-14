using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricl_Destroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
