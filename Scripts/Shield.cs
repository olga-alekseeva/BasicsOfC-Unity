using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlekseevaOlgaLes1
{


    public class Shield : MonoBehaviour
    {

        public float cooldown;

        [HideInInspector] public bool isCooldown;

        private Image _shieldImage;
        private Player player;

        
        void Start()
        {
            _shieldImage = GetComponent<Image>();
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
            isCooldown = true;
        }

        
        void Update()
        {
            if(isCooldown)
            {
                _shieldImage.fillAmount -= 1 / cooldown * Time.deltaTime;
                if(_shieldImage.fillAmount <=0)
                {
                    _shieldImage.fillAmount = 1;
                    isCooldown = false;
                    player.Shield.SetActive(false);
                    gameObject.SetActive(false);
                }
            }
        }
        public void ResetTimer()
        {
            _shieldImage.fillAmount = 1;
        }
    }
}
