using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{

    private GameObject pointText;

    //得点用配列変数
    private int pt = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のPointTextオブジェクトを取得
        this.pointText = GameObject.Find("PointText");

    }

    // Update is called once per frame
    void Update()
    {
        //得点の表示
        this.pointText.GetComponent<Text>().text = "Score" + pt.ToString();

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            pt += 10;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            pt += 20;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            pt += 30;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            pt += 40;
        }
    }
}

