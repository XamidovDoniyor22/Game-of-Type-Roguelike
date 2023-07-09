using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private Animator _animator;
    private void Start()
    {     
        _animator = GetComponent<Animator>();
        EnemyFlyAnimation();
    }
    private void EnemyFlyAnimation()
    {
        _animator.SetBool("isFly", true);
    }
}
