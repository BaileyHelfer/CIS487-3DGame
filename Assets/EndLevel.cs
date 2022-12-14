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

            hitCheckpoint = true;
        }
       
        if (other.gameObject.CompareTag("FinishLine"))
        {
            Debug.Log("HIT FINISH LINE");
            if (hitCheckpoint) {
                if (this.gameObject.tag == "AICar")
                {
                    SceneManager.LoadScene("EndLevelAI");
                }
                else
                {
                    SceneManager.LoadScene("EndLevelPlayer");
                }
                //SceneManager.LoadScene("MainMenu");
                print("checkpointswork");
            }
        }
    
     }
}
