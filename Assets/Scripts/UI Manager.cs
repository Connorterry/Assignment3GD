using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    public void LoadFirstLevel() {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(1);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

        public void OnSceneLoaded(Scene scene, LoadSceneMode mode){
        //if(scene.buildIndex == 1){
            // GameObject objectButton = GameObject.FindWithTag("QuitButton");
            // Button quitButton = objectButton.GetComponent<Button>();
            // quitButton.onClick.AddListener(QuitGame);
            // healthBar = GameObject.FindWithTag("PlayerHealthBar");
            // healthBarImage = healthBar.GetComponent<Image>();
            // player = GameObject.FindWithTag("Player");
            // playerTransform = player.GetComponent<Transform>();
            //parentHealth = GameObject.FindWithTag("HealthBar").GetComponent<Image>();
        //}
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
