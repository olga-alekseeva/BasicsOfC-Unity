using UnityEngine;
using Random = UnityEngine.Random;

namespace AlekseevaOlgaLes1
{

    public abstract class InteractiveObject:MonoBehaviour, IInteractable 
    {
        public bool IsInteractable { get; } = true;

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            Destroy(gameObject);
        }

        protected abstract void Interaction();

        private void Start()
        {
            ((IAction)this).Action();
            ((IInitialization)this).Action();

        }

        void IAction.Action()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Random.ColorHSV();
            }
        }


        void IInitialization.Action()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Color.cyan;
            }
        }


    }
}
