using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject item;
    [SerializeField] private List<GameObject> itemList = new List<GameObject>();

    private Tweener tweener;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
  
        tweener  = GetComponent<Tweener>();
        itemList.Add(item);
        StartCoroutine(waitSeconds(3.5f));
    }

    IEnumerator waitSeconds(float i){ // Just waiting for intro music to end
        yield return new WaitForSeconds(i);
        StartCoroutine(MovePacStudent());
    }

    IEnumerator MovePacStudent(){
        while(true){
        Vector3 [] endPos = new Vector3 []{
        new Vector3(-3.432f,3.981f,0.0f), // top left
        new Vector3(-0.23199f,3.981f,0.0f), // top right
        new Vector3(-0.23199f,1.421f,0.0f), // bottom right
        new Vector3(-3.432f,1.421f,0.0f) // bottom left
        };
        
        for(int j=0;j<4;j++) {
            float duration = Vector3.Distance(item.transform.position,endPos[j])/2.0f; 
            // ^^ Linear movement calculation based on distance between start and endpoints rather than duration
            //float duration = 1.5f;
            switchAnim(j);
            tweener.AddTween(item.transform,item.transform.position,endPos[j],duration);
            yield return new WaitForSeconds(duration);
            }
        }

    }

    public void switchAnim(int i){
            switch (i) {
        case 0:
            animator.SetTrigger("MovingUp");
            break;
        case 1:
            animator.SetTrigger("MovingRight");
            break;
        case 2:
            animator.SetTrigger("MovingDown");
            break;
        case 3:
            animator.SetTrigger("MovingLeft");
            break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
       /* if(Input.GetKeyDown(KeyCode.W)){
            Vector3 endPos = new Vector3(0.0f,0.5f,2.0f);
            float duration = 1.5f;
            foreach(GameObject i in itemList){
                if(tweener.AddTween(i.transform,i.transform.position,endPos,duration)){
                    break;
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.A)){
            Vector3 endPos = new Vector3(-2.0f,0.5f,0.0f);
            float duration = 1.5f;
            foreach(GameObject i in itemList){
                if(tweener.AddTween(i.transform,i.transform.position,endPos,duration)){
                    break;
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.S)){
            Vector3 endPos = new Vector3(0.0f,0.5f,-2.0f);
            float duration = 1.5f;
            foreach(GameObject i in itemList){
                if(tweener.AddTween(i.transform,i.transform.position,endPos,duration)){
                    break;
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.D)){
            Vector3 endPos = new Vector3(2.0f,0.5f,0.0f);
            float duration = 1.5f;
            foreach(GameObject i in itemList){
                if(tweener.AddTween(i.transform,i.transform.position,endPos,duration)){
                    break;
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject newClone = Instantiate(item, new Vector3(0.0f,0.5f,0.0f),Quaternion.identity);
            itemList.Add(newClone);
        }
        */
    }
}
