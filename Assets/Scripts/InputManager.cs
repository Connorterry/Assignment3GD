using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject item;
    private Tweener tweener;
    public Vector3 aEndPos = new Vector3(-2.0f,0.5f,0.0f);
    public Vector3 dEndPos = new Vector3(2.0f,0.5f,0.0f);
    public Vector3 sEndPos = new Vector3(0f,0.5f,-2.0f);
    public Vector3 wEndPos = new Vector3(0f,0.5f,2.0f);


    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("a")){
            Tweener.AddTween(item.transform, item.transform.position, aEndPos,1.5f);
        }
        if(Input.GetKeyDown("d")){
            Tweener.AddTween(item.transform, item.transform.position, dEndPos,1.5f);
        }
        if(Input.GetKeyDown("s")){
            Tweener.AddTween(item.transform, item.transform.position, sEndPos,1.5f);
        }
        if(Input.GetKeyDown("w")){
            Tweener.AddTween(item.transform, item.transform.position, wEndPos,1.5f);
        }
    }
}
