using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorControler : MonoBehaviour
{
    Animator anim;
    //public TriggerEvent openTrigger;
    //public TriggerEvent closeTrigger;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    //private void Update()
    //{
    //    if (openTrigger.isTriggered)
    //    {
    //        anim.SetTrigger("Open");
    //    }
    //    else if (!openTrigger.isTriggered)
    //    {
    //        anim.SetTrigger("Close");
    //    }
    //    else if (!closeTrigger.isTriggered)
    //    {
    //        anim.SetTrigger("Open");
    //    }
    //    else if (closeTrigger.isTriggered)
    //    {
    //        anim.SetTrigger("Close");
    //    }
    //}
}
