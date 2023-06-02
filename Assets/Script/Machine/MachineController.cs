using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineController : MonoBehaviour
{
    public Trigger trigger;
    public Action action;
    // Start is called before the first frame update
    void Start()
    {
        this.trigger = transform.Find("Trigger").GetComponent<Trigger>();
        this.action = transform.Find("Action").GetComponent<Action>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
