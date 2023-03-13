using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptPlayerController : MonoBehaviour
{
    #region private variables
    private Rigidbody rb;
    #endregion

    #region public variables
    public float KeyboardSpeed = 10.0f;
    public float AccelerometerSpeed = 400.0f;

    public TextMeshProUGUI debugLabel;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start");

        // �����X���[�v�𖳌��ɂ���.
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        rb = GetComponent<Rigidbody>();
    }

    // 
    void FixedUpdate()
    {


    }


    // Update is called once per frame
    void Update()
    {
        var _playerDir = Vector3.zero;

        if (Application.isEditor)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _playerDir.y = 10f;
            }

            _playerDir.x = Input.GetAxis("Horizontal") * KeyboardSpeed;
            _playerDir.z = Input.GetAxis("Vertical") * KeyboardSpeed;

            rb.AddForce(new Vector3(_playerDir.x, _playerDir.y, _playerDir.z));
        }
        else
        {
            // �X�}�z�̌X���Ŋm�x���擾����
            _playerDir.x = Input.acceleration.x;
            _playerDir.y = 0;
            _playerDir.z = Input.acceleration.y;

            // playerDir��0.1�ł�����������s
            if (_playerDir.magnitude > 0.1)
            {
                // �������Œ肵�Čv�Z���₷������
                _playerDir.Normalize();

                _playerDir *= Time.deltaTime;

                // player������
                rb.AddForce(_playerDir * AccelerometerSpeed);
            }
        }

        if (debugLabel != null)
        {
            string msg = $"X:{Input.acceleration.x}\nY:{Input.acceleration.y}\nZ:{Input.acceleration.z}\nX:{_playerDir.x}\nY:{_playerDir.y}\nZ:{_playerDir.z}";
            debugLabel.GetComponent<TextMeshProUGUI>().text = msg;
        }
    }

    /// <summary>
    /// �I�u�W�F�N�g���j�����ꂽ�Ƃ��ɌĂяo����܂�
    /// </summary>
    private void OnDestroy()
    {
        //Debug.Log("OnDestroy");
    }

    /// <summary>
    /// �A�v���P�[�V�������I������O�ɌĂяo����܂�
    /// </summary>
    private void OnApplicationQuit()
    {
        //Debug.Log("OnApplicationQuit");

        // �����X���[�v��L���ɂ���.
        Screen.sleepTimeout = SleepTimeout.SystemSetting;
    }
}
