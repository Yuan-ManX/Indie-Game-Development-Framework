using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameFramework
{
    public class cameraControl : MonoBehaviour
    {
        // 位置
        private Transform  mTraget;

        void Strat()
        {
            // 通过查找tag来寻找Player移动物体的位置
            mTraget = GameObject.FindGameObjectWithTag("Player").transform;
        }

        void LateUpdate()
        {
            // 摄像机位置跟随Player位置移动
            transform.position = new Vector3(mTraget.position.x, mTraget.position.y, -10);
        }
    }
}

