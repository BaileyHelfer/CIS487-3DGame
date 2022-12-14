using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingTime : MonoBehaviour
{
    public GameObject timeBox;
    // Start is called before the first frame update
    void Start()
    {
          float endTime = Time.time;
    string TimeDisplay = endTime.ToString("F0");

    
    timeBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Time: " + TimeDisplay+" Seconds.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
