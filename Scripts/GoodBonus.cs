using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace RollingBall
{
    public class GoodBonus : InteractiveObject, IFly, IFlicker, IEquatable<GoodBonus>  // реализация методов для "хороших" бонусов
    {
        public int Point;

        private Material _material;
        private float _lengthFly;



        //private DisplayBonuses _displayBonuses;



        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFly = Random.Range(1.0f, 5.0f);

            //_displayBonuses = new DisplayBonuses();

        }

        public bool Equals(GoodBonus other)
        {
            return Point == other.Point;
        }

        protected override void Interaction()
        {

            _view.Display(Point);

            //Add bonus
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong
                (Time.time, _lengthFly), transform.localPosition.z);
        }
        public void Flicker()
        {
            _material.color = new Color(_material.color.r, 
                _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }


    }
}