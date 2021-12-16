using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlekseevaOlgaLes1
{

    public class Health : Player
    {
        public int HP;
        public int MaxHP;

        public void TakeHit(int Damage)
        {
            HP -= Damage;

            if (HP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
