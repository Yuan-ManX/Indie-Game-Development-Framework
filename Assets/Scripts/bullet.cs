using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework
{
    public class bullet : MonoBehaviour
    {
        
        public void Start()
        {
            // 物体销毁
            GameObject.Destroy(this.gameObject, 3f);
        }

        public void Update()
        {
            transform.Translate(12 * Time.deltaTime, 0, 0);
        }
    
    }

}
