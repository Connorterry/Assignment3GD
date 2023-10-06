using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    //private Tween activeTween;
    private List<Tween> activeTweens;
    // Start is called before the first frame update
    void Start()
    {
        activeTweens = new List<Tween>();
    }

    // Update is called once per frame
        public bool AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if(!TweenExists(targetObject)){
            activeTweens.Add(new Tween(targetObject, startPos, endPos, Time.time, duration));
            return true;
        }
        else{
            return false;
        }
    }

    public bool TweenExists(Transform target){
        foreach (Tween tween in activeTweens){
            if(tween.Target == target){
                return true;
            }
        }
        return false;
    }
    void Update()
    {

        if(activeTweens!=null){
            for (int i = activeTweens.Count - 1; i >= 0; i--){

                Tween tween = activeTweens[i];

                if(Vector3.Distance(tween.Target.position,tween.EndPos)>0.1f){
                float t = (Time.time - tween.StartTime) / tween.Duration;

                //t = t*t*t; don't need this... movement linear...

                Vector3 nextPos = Vector3.Lerp(tween.StartPos, tween.EndPos, t);
                tween.Target.position = nextPos;
                }
                else
                {
                    tween.Target.position = tween.EndPos;
                    activeTweens.RemoveAt(i);
                }
            }
        }
    }
    



    //public float EaseInCubicFunc(float time) {
        // return time * time * time;
    //}

}
