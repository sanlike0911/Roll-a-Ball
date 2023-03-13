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

        // 自動スリープを無効にする.
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
            // スマホの傾きで確度を取得する
            _playerDir.x = Input.acceleration.x;
            _playerDir.y = 0;
            _playerDir.z = Input.acceleration.y;

            // playerDirが0.1でも動いたら実行
            if (_playerDir.magnitude > 0.1)
            {
                // 数字を固定して計算しやすくする
                _playerDir.Normalize();

                _playerDir *= Time.deltaTime;

                // player動かす
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
    /// オブジェクトが破棄されたときに呼び出されます
    /// </summary>
    private void OnDestroy()
    {
        //Debug.Log("OnDestroy");
    }

    /// <summary>
    /// アプリケーションが終了する前に呼び出されます
    /// </summary>
    private void OnApplicationQuit()
    {
        //Debug.Log("OnApplicationQuit");

        // 自動スリープを有効にする.
        Screen.sleepTimeout = SleepTimeout.SystemSetting;
    }
}
