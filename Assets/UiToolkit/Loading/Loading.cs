using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    UIDocument loadingScreen;

    Label text1;

    private AsyncOperation loadAsync;

    private float currentPErcent = 0;

      private IEnumerator coroutine;

    private void OnEnable(){

        loadingScreen = GetComponent<UIDocument>();
        VisualElement root = loadingScreen.rootVisualElement;

        text1 = root.Q<Label>("LoadingText");
        text1.text = "Cargando...";
    }

    void Start() {
        currentPErcent = 0;
    }

    void Update(){
        if(loadAsync != null && currentPErcent >= 100){
            StopCoroutine(coroutine);
            if(text1 != null) {
                text1.text = "Precione espacio para continuar";
            }
            if (Input.GetKeyDown(KeyCode.Space)){
                loadAsync.allowSceneActivation = true;
            }
        } else if(loadAsync == null){
            coroutine = LoadingLevel();
            StartCoroutine(coroutine);
        }
    }

    private IEnumerator LoadingLevel(){
        loadAsync = SceneManager.LoadSceneAsync("SecondScene");
        loadAsync.allowSceneActivation = false;
        while(!loadAsync.isDone){
            currentPErcent = loadAsync.progress * 100 / 0.9f;
            Debug.Log(currentPErcent);
            yield return null;
        }
    }


}
