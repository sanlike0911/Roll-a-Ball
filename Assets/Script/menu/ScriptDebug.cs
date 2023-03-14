using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptDebug : MonoBehaviour
{
    public void OnClickDebugButton()
    {
        for (int _stageId = 0; _stageId < Preferences.StageIdMax; _stageId++)
        {
            Preferences.setBestTime(_stageId, 999.99f);
            Preferences.setClearFlg(_stageId, 0);
        }
        SceneManager.LoadScene("MenuScene");
    }

    void Awake()
    {
        GameObject _btnMenuDebug = GameObject.FindGameObjectWithTag("btnMenuDebug");
        if (Application.isEditor)
        {
            _btnMenuDebug.SetActive(true);
        } else
        {
            _btnMenuDebug.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
