using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameFramework
{
    public class MainPanel : MonoBehaviour
    {
        // 声明变量
        public Text mTxt;


        public void Start()
        {
            mTxt = transform.Find("ScoreTxt").GetComponent<Text>();
        }

        public void UpdateScoreTxt(int score)
        {
            int temp = int.Parse(mTxt.text);
            mTxt.text = (temp + score).ToString();
        }
    }
}
