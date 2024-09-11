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
        //Ư�� ���� ������Ʈ�� ���(Scene) ���� �ı����� �ʵ��� �����ϰ� ���ݴϴ�.
        //����� ������ �� �ش� ���� ������Ʈ�� ����ؼ� �����ϵ��� �մϴ�.
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
        screenImage.gameObject.SetActive(true); //���� ������Ʈ Ȱ��ȭ 

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);

        //<asyncOperation.allowSceneActivation>
        // ����� �غ�� ��� ����� Ȱ��ȭ�Ǵ°��� ����ϴ� ����.
        asyncOperation.allowSceneActivation = false; // Ȱ��ȭ�� ���´�.

        Color color = screenImage.color;

        color.a = 0f;
        //<asyncOperation.isDone>
        //�ش� ������ �Ϸ�Ǿ����� ��Ÿ���� ���� �Դϴ�. (�б� ����)
        while (asyncOperation.isDone == false) 
        {
            color.a += Time.deltaTime;

            screenImage.color = color;


            //<asyncOperation.progress>
            // �۾��� ���� ���¸� ��Ÿ������ �����Դϴ�.(�б� ����)
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
        //Fade In ȣ��
        // Debug.Log("Fade In");
        StartCoroutine(FadeIn());

    }

    public IEnumerator FadeIn()
    {
        #region ��Ǯ��

        ////Color ���� ����

        ////Color ������ Screen Image color �� �����Ѵ�.
        //Color color = screenImage.color;

        ////color �� Alpha���� 1�� �����Ѵ�.
        //color.a = 1.0f;

        ////ScreenImage�� Ȱ��ȭ �մϴ�.
        //screenImage.gameObject.SetActive(true);

        ////�ݺ������� color�� alpha���� 0���� ũ�ų� ���ٸ�
        ////�ݺ��� �����Ѵ�.

        //while(color.a >= 0f)
        //{
        //    //color �� alpha���� ��� ����߷��� ����
        //    color.a -= Time.deltaTime;

        //    //screenImage�� color���� �����մϴ�.
        //    screenImage.color = color;
        //    yield return null;
        //}
        //    //screenImage�� �� Ȱ��ȭ �մϴ�.
        //    screenImage.gameObject.SetActive(false);
        #endregion

        #region ����� Ǯ��
        //Color ���� ����
        //Color ������ Screen Image color �� �����Ѵ�.
        Color color = screenImage.color;

        //color �� Alpha���� 1�� �����Ѵ�.
        color.a = 1;
        //ScreenImage�� Ȱ��ȭ �մϴ�.
        screenImage.gameObject.SetActive(true);
        //�ݺ������� color�� alpha���� 0���� ũ�ų� ���ٸ�
        //�ݺ��� �����Ѵ�.
        while (color.a >= 0.0f)
        {
            //color �� alpha���� ��� ����߷��� ����
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
    //    // ���� ��� 
    //    if(Input.GetKeyDown(KeyCode.Space))
    //    {
    //        SceneManager.LoadScene(1);// �� ���� ��ȣ �ҷ� ���� 

    //    }
    //}