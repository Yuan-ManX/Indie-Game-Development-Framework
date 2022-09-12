using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace GameFramework
{
    public class GamePassPanel : MonoBehaviour
    {

    public void Start()
    {
        transform.Find("GamePassButton").GetComponent<Button>().onClick.AddListener(() => 
        {
            SceneManager.LoadScene("SampleScene");
        });
    }

    public void Update()
    {
        
    }
    }

}
