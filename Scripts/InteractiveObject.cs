using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace RollingBall
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable, IComparable<InteractiveObject> //класс реализации методов для активных предметов

    {
        protected IView _view;
        public event Action<InteractiveObject> OnDestroyChange;

        protected Color _color;

        public bool IsInteractable { get; } = true;

        private void OnTriggerEnter(Collider other)
        {
            if(!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }

            Interaction();

         //   OnDestroyChange?.Invoke(this);
          
            Destroy(gameObject);
        }
        protected abstract void Interaction();

        private void Start()
        {
            //((IAction)this).Action();
            Action();

        }

        // void IAction.Action()
        //{
        //if (TryGetComponent(out Renderer renderer))
        //    {
        //        renderer.material.color = Random.ColorHSV();
        //    }
        //}
        public void Action()
        {
            _color = Random.ColorHSV();
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = _color;
            }
        }

        public void Initialization(IView view)
        {
            _view = view;

            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Color.cyan;
            }
        }
        public int CompareTo(InteractiveObject other)
        {
            return name.CompareTo(other.name);
        }


    }
}