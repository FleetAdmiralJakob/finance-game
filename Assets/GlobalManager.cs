using UnityEngine;
using System;

public class GlobalManager : MonoBehaviour {
        
        public class Data
        {
                public int Money = 0;
                public int Level = 1;
                public string Time = "No Time";
                public string SavedTime = "No Time";
                public string LastTime = "No Time";
        }

        public static Data data;

        private void Start() {
                data = new Data();
                LoadGame();
        }

        private void Update()
        {
                data.Time = DateTime.Now.ToString();
        }
        
        public static void SaveGame()
        {
                data.SavedTime = data.Time;
                PlayerPrefs.SetInt("Money", data.Money);
                PlayerPrefs.SetInt("Level", data.Level);
                PlayerPrefs.SetString("SavedTime", data.SavedTime);
        }
        
        private static void LoadGame()
        {
                if (PlayerPrefs.HasKey("Money") && PlayerPrefs.HasKey("Level") && PlayerPrefs.HasKey("SavedTime")) {
                        data.Money = PlayerPrefs.GetInt("Money");
                        data.Level = PlayerPrefs.GetInt("Level");
                        data.LastTime = PlayerPrefs.GetString("SavedTime");
                } else if (PlayerPrefs.HasKey("Money") && PlayerPrefs.HasKey("Level")) {
                        data.Money = PlayerPrefs.GetInt("Money");
                        data.Level = PlayerPrefs.GetInt("Level");
                } else if (PlayerPrefs.HasKey("Money") && PlayerPrefs.HasKey("SavedTime")) {
                        data.Money = PlayerPrefs.GetInt("Money");
                        data.LastTime = PlayerPrefs.GetString("SavedTime");
                } else if (PlayerPrefs.HasKey("Level") && PlayerPrefs.HasKey("SavedTime")) {
                        data.Level = PlayerPrefs.GetInt("Level");
                        data.LastTime = PlayerPrefs.GetString("SavedTime");
                }else if (PlayerPrefs.HasKey("Money"))
                {
                        data.Money = PlayerPrefs.GetInt("Money");
                } else if (PlayerPrefs.HasKey("Level"))
                {
                        data.Level = PlayerPrefs.GetInt("Level");
                } else if (PlayerPrefs.HasKey("SavedTime"))
                {
                        data.LastTime = PlayerPrefs.GetString("SavedTime");
                }
        }
}