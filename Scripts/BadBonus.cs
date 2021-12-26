using UnityEngine;
using Random = UnityEngine.Random;
using System;

namespace RollingBall
{
    public class BadBonus : InteractiveObject, IFly, IRotation, ICloneable // реализация методов для "плохих" бонусов
    {
        private float _lengthFly;
        private float _speedRotation;

        private event EventHandler<CaughtPlayerEventArgs> _caughtPlayer;
        public event EventHandler<CaughtPlayerEventArgs> CaughtPlayer

        {
            add { _caughtPlayer += value; }
            remove { _caughtPlayer -= value; }
        }

        //public delegate void CaughtPlayerChange(object value);
        //private event CaughtPlayerChange caughtPlayer;


//        public event CaughtPlayerChange CaughtPlayer
      
//        { 
//        add { caughtPlayer += value;}
//        remove { caughtPlayer -= value;}
//          }

       
        private void Awake()
        {
            _lengthFly = Random.Range(0.0f, 3.0f);
            _speedRotation = Random.Range(10.0f, 50.0f);
        }

        protected override void Interaction()
        {
            //caughtPlayer.Invoke(value: this);
           // _caughtPlayer?.Invoke(this, _color);
            _caughtPlayer?.Invoke(this, new CaughtPlayerEventArgs(_color));

        }
        public object Clone()
        {
            var result = Instantiate(gameObject, transform.position, transform.rotation, transform.parent);
            return result;
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFly),
                transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

     
    }
}