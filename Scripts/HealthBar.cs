using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class HealthBar : MonoBehaviour
{


    public Image ImgHealthBar;
    public Text TxtHealth;
    public int Min;
    public int Max;
    private int mCurrentValue;
    private float mCurrentPercent;
    public static int health;

    public static HealthBar Instance { get; private set; }
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
    }


    public void SetHealth(int health)
    {
        if (health != mCurrentValue)
        {
            if (Max - Min == 0)
            {
                mCurrentValue = 0;
                mCurrentPercent = 0;
            }
            else
            {
                mCurrentValue = health;
                mCurrentPercent = (float)mCurrentValue / (float)(Max - Min);
            }

            if (TxtHealth.text != null)
                {
                TxtHealth.text = string.Format("THIRST");
                ImgHealthBar.fillAmount = mCurrentPercent;
                }
            /*if (TxtHealth.text != null)
                {
                TxtHealth.text = string.Format("{0} %", Mathf.RoundToInt(mCurrentPercent * 100));
                ImgHealthBar.fillAmount = mCurrentPercent;
            }*/
        }
    }

    public float CurrentPercent
    {
        get { return mCurrentPercent; }
    }

    public int CurrentValue
    {
        get { return mCurrentValue; }

    }
}


