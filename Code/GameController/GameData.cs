using UnityEngine;
using UnityEngine.UI;

namespace RollABall
{
    [CreateAssetMenu(fileName = "GameData", menuName = "Data/GameData")]
    public sealed class GameData : ScriptableObject
    {
        [Header("Game version")]
        public string CurrentGameVersion;

        [Header("UI controller")]
      
        public Canvas PrefabCanvasMain;
        public Canvas PrefabTXTGameVersion;
        public Canvas PrefabTXTBonus;
        public Canvas PrefabCanvasResetButton;
        public Button PrefabRestartButton;
        
        public T Load<T>(string path) where T : Object
        {
            var file = Resources.Load<T>(path);
            if (file = null) throw new System.NullReferenceException($"file has not been found in path: Resources/{path}");
            return file;
        }



    }
}