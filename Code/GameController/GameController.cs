using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RollABall
{
    public sealed class GameController : MonoBehaviour
    {
        private const string GAME_DATA_PATH = "GameData";

        private GameData _data;
        private ControllersRepository _repository;
        private RestartButtonAction _restart;
     //  private Reference _reference;
        private void Awake()
        {
            _data = Resources.Load<GameData>(GAME_DATA_PATH);
            _repository = new ControllersRepository();

            RestartButtonAction restart = new RestartButtonAction();


         // _reference.RestartButton.onClick.AddListener(restart.RestartGame);
        // _reference.RestartButton.gameObject.SetActive(false);

            new Initializator(_data, _repository);

          

        }

        private void Update() => _repository.LogicUpdate(Time.deltaTime);
        private void FixedUpdate() => _repository.PhysicsUpdate(Time.deltaTime);
        private void LateUpdate() => _repository.LateUpdate(Time.deltaTime);

        private void OnDestroy() => _repository.CleanUp();
   

    }
}