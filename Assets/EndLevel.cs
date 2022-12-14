using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndLevel : MonoBehaviour
{
    public bool hitCheckpoint = false;
    private void OnTriggerEnter(Collider other)
    {  

        if (other.gameObject.CompareTag("Checkpoint1"))
        {
            print("checkpointswork");
            hitCheckpoint = true;
        }
        if (other.gameObject.CompareTag("FinishLine"))
        {
            if (hitCheckpoint) {
                SceneManager.LoadScene("MainMenu");
                print("checkpointswork");
            }
        }
    
     }
}
