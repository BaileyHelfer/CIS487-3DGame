using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoostCooldown : MonoBehaviour
{
    public Image boostImage;
    public Image fullBostImg;
    public bool boostCooldown = false;
    public bool firstClick = true;
    public bool boosting = false;
    public float endBoost;
    public float startBoost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(fullBostImg.fillAmount);
        if (boosting)
        {
            if (Time.time - startBoost < 5f)
            {
                Debug.Log("BOOSTING");
                if (fullBostImg.fillAmount > 0.85f)
                {
                    fullBostImg.fillAmount = 0.85f;
                }
                fullBostImg.fillAmount -= 0.85f / 5f * Time.deltaTime;

            }
            else
            {
 
                //if (fullBostImg.fillAmount >= 80)
                //{
                //    fullBostImg.fillAmount = 1f;
                //}
                
                boostCooldown = true;
                endBoost = Time.time;
                firstClick = true;
                boosting = false;

            }
        }
        if (boostCooldown)
        {
            if (fullBostImg.fillAmount > 0.80f)
            {
                fullBostImg.fillAmount = 1f;
            }
            fullBostImg.fillAmount += 0.80f / 10f * Time.deltaTime;
            if (Time.time - endBoost > 10f)
            {
                boostCooldown = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) { 
            if (boostCooldown)
            {
                if (Time.time - endBoost < 10f)
                {
                    Debug.Log("COOLDOWN");
                    return;
                }
                else
                {
                    boostCooldown = false;
                }
            }
            if (firstClick)
            {
                startBoost = Time.time;
                boosting = true;
                firstClick = false;
            }
        }
    }
}
