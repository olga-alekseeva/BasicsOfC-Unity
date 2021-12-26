using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace RollingBall
{
    public class GameController : MonoBehaviour, IDisposable //точка входа в приложении
    {
        public Text _finishGameLabel;
        public Text _BonusCount;

        private List<InteractiveObject> _interactiveObjects;

        private ListInteractableObject _interactiveObject;


        private DisplayEndGame _displayEndGame;


        private void Awake()
        {
            _interactiveObjects = FindObjectsOfType<InteractiveObject>().ToList();
            var displayBonuses = new DisplayBonuses();

            foreach (var interactiveObject in _interactiveObjects)
            {
                interactiveObject.Initialization(displayBonuses);
                interactiveObject.OnDestroyChange += InteractiveObjectOnOnDestroyChange;
            }


            _interactiveObject = new ListInteractableObject();
            _displayEndGame = new DisplayEndGame(_finishGameLabel);
            foreach (var o in _interactiveObject)
            {
                if (o is BadBonus badBonus)
                {
                    badBonus.CaughtPlayer += CaughtPlayer;
                    badBonus.CaughtPlayer += _displayEndGame.GameOver;
                }
            }

        }
            private void CaughtPlayer(object value, CaughtPlayerEventArgs args)
            {
                Time.timeScale = 0.0f;
            }



        private void InteractiveObjectOnOnDestroyChange(InteractiveObject value)
        {
            value.OnDestroyChange -= InteractiveObjectOnOnDestroyChange;
            _interactiveObjects.Remove(value);
        }

        private void Update()
        {

            for (var i = 0; i < _interactiveObjects.Count; i++)
            {
                var interactiveObject = _interactiveObjects[i];

                if (interactiveObject == null)
                {
                    continue;
                }
                if (interactiveObject is IFly fly)
                {
                    fly.Fly();
                }
                if(interactiveObject is IFlicker flicker)
                {
                    flicker.Flicker();
                    if(interactiveObject is IRotation rotation)
                    {
                        rotation.Rotation();
                    }
                }
            }
        }
        public void Dispose()
        {
            foreach (var o in _interactiveObject)
            {
                if (o is InteractiveObject interactiveObject)
                {
                    Destroy(interactiveObject.gameObject);
                    if (o is BadBonus badBonus)
                    {
                        badBonus.CaughtPlayer -= CaughtPlayer;
                        badBonus.CaughtPlayer -= _displayEndGame.GameOver;
                    }
                    Destroy(interactiveObject.gameObject);

                }
            }
        }


    }
}