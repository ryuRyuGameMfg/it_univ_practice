using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private void OnTriggerEnter(Collider t)
    {
        switch (t.gameObject.tag)
        {
            case "Player":
                this.transform.parent.GetComponent<Enemy>().Attack(t.gameObject);
                break;
        }
    }
}
