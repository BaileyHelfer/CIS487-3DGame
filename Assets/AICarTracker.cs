using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTracker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TheMarker;
    public GameObject[] markers;
    public int MarkTracker;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(markers[MarkTracker]);
        TheMarker.transform.position = markers[MarkTracker].transform.position;
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "AICar")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker++;
            if (MarkTracker == markers.Length)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds (1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
