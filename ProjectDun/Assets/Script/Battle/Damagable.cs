using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField] public Stat stat;     // 피격자 본인의 스탯.
    float attackedPower;

    public void Damaged(Stat stat)
    {
        attackedPower = stat.basic.attackPower;
        this.stat.basic.hp -= attackedPower;
        Debug.Log($"{name}의 체력 : "+ this.stat.basic.hp);
        BottomUI.Instance.UpdateBottomUi();
    }
}
