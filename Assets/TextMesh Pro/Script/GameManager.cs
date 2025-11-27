using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour
{ 
    private static string SaveFile = ("Savedata.json");

    public static GameManager Instance;
    public UserData userData = new UserData();

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
        userData = new UserData("김재경", 850000, 1150000);
        DontDestroyOnLoad(gameObject);
        Load();
    }

    public GameObject imageRestart;

    // Start is called before the first frame update
    void Start()
    {
        //활성화, 비활성화
        imageRestart.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //restart 버튼을 누르면
    public void OnClickRestart()
    {
        //첫 장면을 가져오게 된다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Save()
    {
        try
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented
            };
            string json = JsonConvert.SerializeObject(userData, settings);
            File.WriteAllText(SaveFile, json);
            Debug.Log(json);
            Debug.Log("파일이 경로에 성공적으로 저장되었습니다.");
        }
        catch (Exception)
        {
            Debug.Log("파일 저장 에러 발생");
        }
    }

    public void Load()
    {
        if (!File.Exists(SaveFile))
        {
            userData = new UserData("김재경", 850000, 1150000);
        }
        try
        {
            string json = File.ReadAllText(SaveFile);
            userData = JsonConvert.DeserializeObject<UserData>(json);
        }
        catch (Exception)
        {
            Debug.Log("불러왔습니다.");
        }
    }

    private void OnApplicationQuit()
    {
        Save();
    }
}





