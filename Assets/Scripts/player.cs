using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace GameFramework
{
    public class player : MonoBehaviour
    {
        // 新建变量
        public Rigidbody2D mRig;
        // 左右移动值
        public float moveValue = 6f;
        // 上下跳跃值
        public float jumpValue = 16f;

        public bool mJumpInput;
        private MainPanel mMainPanel;

        public void Start()
        {
            // 获取组件的刚体值
            mRig = GetComponent<Rigidbody2D>();
            mMainPanel = GameObject.Find("MainPanel").GetComponent<MainPanel>();

        }

        public void Update()
        {
            // 按下j键，加载预制体
            if (Input.GetKeyDown(KeyCode.J))
            {
                // 通过Resources文件加载预制体
                var bullet = Resources.Load<GameObject>("Bullet");
                // 在本地实例化Instance这个对象
                GameObject.Instantiate(bullet, transform.position, Quaternion.identity);

            }
        }
        
        public void FixedUpdate()
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

        public void OnTriggerEnter2D(Collider2D coll)
        {
            // 判断是否触发Reward
            if (coll.gameObject.CompareTag("Reward"))
            {
                // 销毁物体
                GameObject.Destroy(coll.gameObject);
                // 分数增加
                mMainPanel.UpdateScoreTxt(1);
            }
            
            // 判断是否为Door的触发状态
            if (coll.gameObject.CompareTag("Door"))
            {
                // 加载新场景
                SceneManager.LoadScene("GamePassScene");
            }
        }
    }

}
