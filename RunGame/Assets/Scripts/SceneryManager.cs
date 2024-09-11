using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneryManager : MonoBehaviour
{
    [SerializeField] Image screenImage;

    private void Awake()
    {
        //특정 게임 오브젝트가 장면(Scene) 간에 파괴되지 않도록 유지하게 해줍니다.
        //장면을 변경할 때 해당 게임 오브젝트가 계속해서 존재하도록 합니다.
        DontDestroyOnLoad(gameObject);

    }

    void Start()
    {
       //StartCoroutine(FadeIn());
    }

    private void OnEnable()
    {
       SceneManager.sceneLoaded += OnSceneLoaded;
    }



    public IEnumerator AsyncLoad(int index)
    {
        screenImage.gameObject.SetActive(true); //게임 오브젝트 활설화 

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);

        //<asyncOperation.allowSceneActivation>
        // 장면이 준비된 즉시 장면이 활성화되는것을 허용하는 변수.
        asyncOperation.allowSceneActivation = false; // 활성화를 막는다.

        Color color = screenImage.color;

        color.a = 0f;
        //<asyncOperation.isDone>
        //해당 동작이 완료되었는지 나타내는 변수 입니다. (읽기 전용)
        while (asyncOperation.isDone == false) 
        {
            color.a += Time.deltaTime;

            screenImage.color = color;


            //<asyncOperation.progress>
            // 작업의 진행 상태를 나타내내는 변수입니다.(읽기 전용)
            if (asyncOperation.progress >= 0.9f )
            {
                color.a = Mathf.Lerp(color.a, 1f, Time.deltaTime);

                screenImage.color = color;

                if(color.a >= 1.0f)
                {
                    asyncOperation.allowSceneActivation = true;

                    yield break;
                }

            }
             yield return null;  
        }
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(AsyncLoad(1));
        }
    }

    void OnSceneLoaded (Scene scene, LoadSceneMode mode)
    {
        //Fade In 호출
        // Debug.Log("Fade In");
        StartCoroutine(FadeIn());

    }

    public IEnumerator FadeIn()
    {
        #region 내풀이

        ////Color 변수 선언

        ////Color 변수에 Screen Image color 를 저장한다.
        //Color color = screenImage.color;

        ////color 의 Alpha값을 1로 설정한다.
        //color.a = 1.0f;

        ////ScreenImage를 활성화 합니다.
        //screenImage.gameObject.SetActive(true);

        ////반복문으로 color의 alpha갑시 0보다 크거나 같다면
        ////반복을 수행한다.

        //while(color.a >= 0f)
        //{
        //    //color 의 alpha값을 계속 떨어뜨려준 다음
        //    color.a -= Time.deltaTime;

        //    //screenImage의 color값에 저장합니다.
        //    screenImage.color = color;
        //    yield return null;
        //}
        //    //screenImage를 비 활성화 합니다.
        //    screenImage.gameObject.SetActive(false);
        #endregion

        #region 강사님 풀이
        //Color 변수 선언
        //Color 변수에 Screen Image color 를 저장한다.
        Color color = screenImage.color;

        //color 의 Alpha값을 1로 설정한다.
        color.a = 1;
        //ScreenImage를 활성화 합니다.
        screenImage.gameObject.SetActive(true);
        //반복문으로 color의 alpha갑시 0보다 크거나 같다면
        //반복을 수행한다.
        while (color.a >= 0.0f)
        {
            //color 의 alpha값을 계속 떨어뜨려준 다음
            color.a -= Time.deltaTime;

            screenImage.color = color;

            yield return null;
        }
        screenImage.gameObject.SetActive(false);

     

        #endregion

    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}

    //private void Update()
    //{
    //    // 동기 방식 
    //    if(Input.GetKeyDown(KeyCode.Space))
    //    {
    //        SceneManager.LoadScene(1);// 신 빌드 번호 불러 오기 

    //    }
    //}