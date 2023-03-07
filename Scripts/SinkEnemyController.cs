using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


namespace UnityStandardAssets.Characters.ThirdPerson
{
    public class SinkEnemyController : MonoBehaviour 
    {


        private SinkHealth sinkHealthBar;
       // public GameObject Player;
        public int sinkHealth = 100;
        public Image SinkImgHealthBar;
        public Text SinkTxtHealth;
        public int Min;
        public int Max;
        private int mCurrValue;
        private float mCurrPercent;
        private GameObject sink;
        public int damage = 5;
      
      public static bool using_hammer; 



/*
public void Update()
    {
    Using_hammer();
    }

  public static void Using_hammer()
       {
           if ()
            //if (SledgeHammer.onUse == true)
             {
               using_hammer = true;
               Debug.Log(using_hammer);
            } 
       }
       
*/



        //determine health
        public void SetSinkHealth(int sinkHealth)
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



        //sethealthbar
        public void TakeSinkDamage(int amount)
        {
            sinkHealth -= amount;
            if (sinkHealth < 0)
                sinkHealth = 0;
            if(sinkHealth == 0)
            {
                Destroy(this.gameObject);
                Destroy(GameObject.Find("sink_wall"));
                Destroy(GameObject.Find("beacon_light"));
                //Destroy(GameObject.Find("clock"));
                Destroy(GameObject.Find("pic1"));
                Destroy(GameObject.Find("pic2"));
                Destroy(GameObject.Find("CanvasA").gameObject.transform.GetChild(0).GetChild(10));
            }

            SetSinkHealth(sinkHealth);
        }



        private void OnCollisionEnter(Collision other)
        {
            //if (Player.GetComponent<ThirdPersonCharacter>().IsAttacking), //check if use item method = true

            GameObject hammerChild = GameObject.Find("ThirdPersonController").gameObject.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(2).gameObject;
            if (GameObject.Find("ThirdPersonController").GetComponent<ThirdPersonCharacter>().IsAttacking && hammerChild != null)
            //&& using_hammer == true) 
            //Debug.Log("attacking and using hammer");

// HUDSingleton.Instance.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().enabled == true;
                {
                    TakeSinkDamage(damage);
                   // Debug.Log("damage");
                }
        }

    }
}