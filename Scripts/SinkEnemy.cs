using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinkEnemy : MonoBehaviour
{


    public Image SinkImgHealthBar;
    public Text SinkTxtHealth;
    public int Min;
    public int Max;
    private int mCurrValue;
    private float mCurrPercent;



    public void SetHealth(int sinkHealth)
    {
        if (sinkHealth != mCurrValue)
        {
            if (Max - Min == 0)
            {
                mCurrValue = 0;
                mCurrPercent = 0;
            }
            else
            {
                mCurrValue = sinkHealth;
                mCurrPercent = (float)mCurrValue / (float)(Max - Min);
            }
            SinkTxtHealth.text = string.Format("{0} %", Mathf.RoundToInt(mCurrPercent * 100));
            SinkImgHealthBar.fillAmount = mCurrPercent;
        }
    }

    public float CurrPercent
    {
        get { return mCurrPercent; }
    }

    public int CurrValue
    {
        get { return mCurrValue; }

    }





}

