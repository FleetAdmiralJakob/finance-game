using UnityEngine;

public class GlobalManager : MonoBehaviour {
        
        public class Data {
                public int money = 0;
                public int level = 1;
        }

        public static Data data;

        private void Start()
        {
                data = new Data();
                LoadGame();
        }
        
        public static void SaveGame()
        {
                PlayerPrefs.SetInt("Money", data.money);
                PlayerPrefs.SetInt("Level", data.level);
        }
        
        private static void LoadGame()
        {
                if (PlayerPrefs.HasKey("Money") && PlayerPrefs.HasKey("Level"))
                {
                        data.money = PlayerPrefs.GetInt("Money");
                        data.level = PlayerPrefs.GetInt("Level");
                } else if (PlayerPrefs.HasKey("Money"))
                {
                        data.money = PlayerPrefs.GetInt("Money");
                } else if (PlayerPrefs.HasKey("Level"))
                {
                        data.level = PlayerPrefs.GetInt("Level");
                }
        }
}