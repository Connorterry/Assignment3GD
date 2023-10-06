using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
  
    Transform target;
    Vector3 startPos;
    Vector3 endPos;
    float startTime;
    float duration;

    public Tween(Transform target, Vector3 startPos, Vector3 endPos, float startTime, float duration){
        this.target = target;
        this.startPos = startPos;
        this.endPos = endPos;
        this.startTime = startTime;
        this.duration = duration;
    }
    public Transform getTween(Transform target){
        return target.transform;

    }

}
