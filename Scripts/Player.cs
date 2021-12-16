using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace AlekseevaOlgaLes1
{


    public class Player : MonoBehaviour
    {
        [Header ("Controls")]
        public float Speed = 3.0f;
        private Rigidbody _rigidbody;

        [Header("Health")]
        public int Health;
        public GameObject potionEffect;
        public Text healthDisplay;


        [Header("Shield")]
        public GameObject Shield;
        public Shield shieldTimer;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            healthDisplay.text = "HP: " + Health;


        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * Speed);


        }

        public void ChangeHealth(int HealthValue)
        {
            if(!Shield.activeInHierarchy || Shield.activeInHierarchy && HealthValue >0 )
            Health += HealthValue;
            healthDisplay.text = "HP: " + Health;
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Health"))
            {
                ChangeHealth(5);
                Instantiate(potionEffect, other.transform.position, Quaternion.identity);
                Destroy(other.gameObject);
            }
            else if (other.CompareTag("Shield"))
            {
                Shield.SetActive(true);
                shieldTimer.gameObject.SetActive(true);
                shieldTimer.isCooldown = true;
                Destroy(other.gameObject);
            }
        }

        //private void OnTriggerEnter(Collider other)
        //{
        //    if(other.CompareTag("Health"))
        //    {
        //         IChangeHealth.ChangeHP(5);
        //        Destroy(other.gameObject);
        //    }
        //}
    }
}
