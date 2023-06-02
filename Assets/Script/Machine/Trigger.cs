using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public MachineController Machine;
    // Start is called before the first frame update
    void Start()
    {
        this.Machine = transform.parent.GetComponent<MachineController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.Machine.action.Act();
    }
}
