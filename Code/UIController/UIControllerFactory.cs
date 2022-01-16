using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

using TMPro;

namespace RollABall
{
    public sealed class UIControllerFactory : 
        IFactory<UIController>
    {
        private GameData _gameData;
    public UIControllerFactory(GameData data)
        {
            _gameData = data;
        }

        public  UIController Create()
        {
          // _gameData.PrefabTXTGameVersion.GetComponentInChildren<Text>().text = _gameData.CurrentGameVersion;
            var gameVersion = Object.Instantiate(_gameData.PrefabTXTGameVersion);
            var mainCanvas = Object.Instantiate(_gameData.PrefabCanvasMain);
            var txtBonusDisplay = Object.Instantiate(_gameData.PrefabTXTBonus);
            //var txtBonusDisplay = Resources.Load<Canvas>("UI/BonusDisplay");
            var canvasRestartButton = Object.Instantiate(_gameData.PrefabCanvasResetButton);

            var RestartButton = Button.Instantiate(_gameData.PrefabRestartButton);
            RestartButtonAction restart = new RestartButtonAction();
            RestartButton.onClick.AddListener(restart.RestartGame);
            RestartButton.gameObject.SetActive(false);

            return new UIController(gameVersion);
        }
    }
}