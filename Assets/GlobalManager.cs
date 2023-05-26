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
        
        private static void LoadGame() { 
            void LoadData(string key, ref Data data) {
                if (PlayerPrefs.HasKey(key)) {
                        switch (key) {
                                case "Money":
                                        data.Money = PlayerPrefs.GetInt(key);
                                        break;
                                case "Level":
                                        data.Level = PlayerPrefs.GetInt(key);
                                        break;
                                case "SavedTime":
                                        data.LastTime = PlayerPrefs.GetString(key);
                                        break;
                        }
                }
            }

            if (PlayerPrefs.HasKey("Money")) {
                    LoadData("Money", ref data);
            }
            if (PlayerPrefs.HasKey("Level")) {
                    LoadData("Level", ref data);
            }
            if (PlayerPrefs.HasKey("SavedTime")) {
                    LoadData("SavedTime", ref data);
            }
        }
}