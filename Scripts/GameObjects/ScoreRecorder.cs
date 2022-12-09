using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//直接微改之前的
public class ScoreRecorder : MonoBehaviour {

    public int score;                   //分数
    public int target_score;            //目标分数
    public int arrow_number;            //箭的数量
    void Start()
    {
        score = 0;
        target_score = 15;
        arrow_number = 10;
    }
    //记录分数
    public void Record(GameObject ring)
    {
        int tmp = ring.GetComponent<RingData>().score;
        score = tmp + score;
    }
}
