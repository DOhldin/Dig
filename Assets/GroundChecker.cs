using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour {
    public int isgrounded;
    //om objektet nuddar triggern så händer nedanstående
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isgrounded ++; //kallar om du nuddar hitbox

    }
    //om objektet nuddar triggern  så händer nedanstående
    private void OnTriggerExit2D(Collider2D collision)
    {
        isgrounded --; //  kallar om du inte är på marken
    }



}
