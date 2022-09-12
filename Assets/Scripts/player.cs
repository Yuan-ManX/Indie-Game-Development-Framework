using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameFramework
{
    public class player : MonoBehaviour
    {
        // 新建变量
        private Rigidbody2D mRig;
        // 左右移动值
        private float moveValue = 6f;
        // 上下跳跃值
        private float jumpValue = 16f;

        private void Start()
        {
            // 获取组件的刚体值
            mRig = GetComponent<Rigidbody2D>();

        }

        private void Update()
        {
            // 按下j键，加载预制体
            if (Input.GetKeyDown(KeyCode.J))
            {
                // 通过Resources文件加载预制体
                var bullet = Resources.Load<GameObject>("Bullet");
                // 在本地实例化Instance这个对象
                

            }
        }
        
        private void FixedUpdate()
        {
            // 判断是否按下跳跃键
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // 锁定x值，上下跳跃
                mRig.velocity = new Vector2(mRig.velocity.x, jumpValue);
            }
            // 锁定上下y值，左右移动
            mRig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveValue, mRig.velocity.y);
        }
    }

}
