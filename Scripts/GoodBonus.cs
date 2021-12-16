using UnityEngine;

namespace AlekseevaOlgaLes1
{

    public sealed class GoodBonus : InteractiveObject, IFlicker, IFly, IChangeHealth
    {
        private Material _material;
        private float _lengthFly;
        private DisplayBonuses _displayBonuses;
        [SerializeField]
        int Value = 5;
        int HP;
        int MaxHP;
        int Damage;


        private void Awake()
        {
            _displayBonuses = new DisplayBonuses();
            _material = GetComponent<Renderer>().material;
            _lengthFly = Random.Range(1.0f, 5.0f);
        }

        protected override void Interaction()
        {

            _displayBonuses.Display(ref Value);
            // Add bonus
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFly),
                transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }

        
        public void ChangeHP(int HealthValue)
        {
            HP += HealthValue;

            if (HP > MaxHP)
            {
                HP = MaxHP;
            }
        }

        public void TakeHit()
        {
            HP -= Damage;

            if (HP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}


  
