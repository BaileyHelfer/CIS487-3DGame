using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarDriver : MonoBehaviour
{
    private AICarController controller;

    private void Awake()
    {
        controller = GetComponent<AICarController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controller.GoForward();
    }
}
