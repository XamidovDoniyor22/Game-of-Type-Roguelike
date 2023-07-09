using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private int _speed = -7;
    private float _moveHorizontal;
    private float _moveVertical;

    [Space]
    [SerializeField] private Joystick _joystick;
    private Rigidbody2D _rb;
    private bool _facingRight;
    public bool _isRunAnimationActive;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();   
    }
    private void Update()
    {
        _moveHorizontal = _joystick.Horizontal;
        _moveVertical = _joystick.Vertical;
        FlipSideChecker();
        AnimationCheck();
    }
    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_moveHorizontal * _speed, _moveVertical * _speed);
    }
    private void Flip()
    {
        _facingRight = !_facingRight;
        Vector3 _scaler = transform.localScale;
        _scaler.x *= -1;
        transform.localScale = _scaler;
    }
    private void FlipSideChecker()
    {
        if (_facingRight == false && _moveHorizontal > 0)
        {
            Flip();          
        }
        if (_facingRight == true && _moveHorizontal < 0)
        {
            Flip();      
        }
    }
    private void AnimationCheck()
    {    
        if (_moveHorizontal != 0 || _moveVertical != 0)
        {
            _isRunAnimationActive = true;
        }
        else _isRunAnimationActive = false;
    }
}
