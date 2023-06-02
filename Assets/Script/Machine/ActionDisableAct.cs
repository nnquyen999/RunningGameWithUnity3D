using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionDisableAct : Action
{
    public float disableDelay = 1f;
    public float respawnDelay = 3f;

    public override void Act()
    {
        Invoke(nameof(Disable), this.disableDelay);
        Invoke(nameof(Respawn), this.respawnDelay);
    }  
    
    protected virtual void Disable()
    {
        transform.parent.gameObject.SetActive(false);
    }

    protected virtual void Respawn()
    {
        transform.parent.gameObject.SetActive(true);
    }
}
