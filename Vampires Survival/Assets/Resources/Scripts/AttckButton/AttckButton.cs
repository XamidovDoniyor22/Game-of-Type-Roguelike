using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttckButton : MonoBehaviour
{
    public bool _isAtatckAnimationActive;
    private float attackDuration = 0.15f;

    public void AttackButton()
    {
        StartCoroutine(AttackButtonDuration());
    }
    private IEnumerator AttackButtonDuration()
    {
        _isAtatckAnimationActive = true;
        yield return new WaitForSeconds(attackDuration);
        _isAtatckAnimationActive = false;
    }
}
