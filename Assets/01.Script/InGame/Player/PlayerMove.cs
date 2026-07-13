using _01.Script.Player;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed;
    public GameObject questPanel;

    private float _h;
    private float _v;
    private bool _isHorizontalMove;

    // 마지막으로 입력된 방향을 기억하기 위한 변수
    private float _lastHorizontal = 0f;
    private float _lastVertical = -1f; // 처음에 아래를 바라보도록 함

    private int _count = 0;

    private Rigidbody2D _rigid;
    private Animator _anim;
    private Vector3 _dirVec;
    private GameObject _scanObject;
    
    private bool _hDown;
    private bool _vDown;
    private bool _hUp;
    private bool _vUp;
    
    void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        #region 테스트

        //Debug.Log("asd");
        #endregion
        if(PlayerMovmentCompo.CanManualMove)
        {
            _h = Input.GetAxisRaw("Horizontal");
            _v = Input.GetAxisRaw("Vertical");

            _hDown = Input.GetButtonDown("Horizontal");
            _vDown = Input.GetButtonDown("Vertical"); 
            _hUp = Input.GetButtonUp("Horizontal");
            _vUp = Input.GetButtonUp("Vertical");
        }

        // 2. 2D 대각선 이동 방지 축 고정
        if (_hDown)
            _isHorizontalMove = true;
        else if (_vDown)
            _isHorizontalMove = false;
        else if (_hUp || _vUp)
            _isHorizontalMove = _h != 0;

        // 가장 마지막으로 눌린 키의 방향 업데이트
        if (_hDown && _h != 0)
        {
            _lastHorizontal = _h;
            _lastVertical = 0f;
        }
        if (_vDown && _v != 0)
        {
            _lastVertical = _v;
            _lastHorizontal = 0f;
        }

        // 이동 중일 때도 실시간으로 마지막 입력축을 동기화 (꾹 누르고 있을 때 방향 전환 대응)
        if (_h != 0 || _v != 0)
        {
            if (_isHorizontalMove && _h != 0)
            {
                _lastHorizontal = _h;
                _lastVertical = 0f;
            }
            else if (!_isHorizontalMove && _v != 0)
            {
                _lastVertical = _v;
                _lastHorizontal = 0f;
            }
            _anim.SetBool("IsMove", true);
        }
        else
        {
            _anim.SetBool("IsMove", false);
        }

        // 4. 애니메이터에 "가장 마지막으로 기억된 방향"을 전달 (손을 떼도 유지됨)
        _anim.SetFloat("MoveX", (int)_lastHorizontal);
        _anim.SetFloat("MoveY", (int)_lastVertical);

    }

    void FixedUpdate()
    {
        // 7. 이동 물리 처리
        Vector2 moveVec = _isHorizontalMove ? new Vector2(_h, 0) : new Vector2(0, _v);
        _rigid.linearVelocity = moveVec * speed;
    }
    
}