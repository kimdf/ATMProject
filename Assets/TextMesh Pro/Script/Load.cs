using Newtonsoft.Json;
using System;
using System.IO;
using UnityEngine;

public class Load : MonoBehaviour
{
    private static string SaveFile = ("Savedata.json");
    public UserData userData()
    {
        if (!File.Exists(SaveFile))
        {
            Debug.Log("저장 파일이 경로에 존재하지 않습니다.");
            return null;
        }

        try
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string json = File.ReadAllText(SaveFile);
            UserData? loadedPlayer = JsonConvert.DeserializeObject<UserData>(json, settings);
            Debug.Log("데이터를 성공적으로 불러왔습니다.");

            return loadedPlayer;
        }
        catch (Exception ex)
        {
            Debug.Log("파일 불러오는 중 오류 발생");
            return null;
        }
    }
}