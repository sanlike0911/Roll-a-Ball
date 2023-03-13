using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class Preferences
{
    static public float getBestTime(int _stageId)
    {
        return PlayerPrefs.GetFloat("bestTimeStage" + _stageId.ToString(), (float)999.99);
    }
    static public void setBestTime(int _stageId, float _setBestTime)
    {
        PlayerPrefs.SetFloat("bestTimeStage" + _stageId.ToString(), _setBestTime);
        PlayerPrefs.Save();
    }

    static public int getClearFlg(int _stageId)
    {
        return PlayerPrefs.GetInt("ClearFlgStage" + _stageId.ToString(), (int)1);
    }
    static public void setClearFlg(int _stageId, int _clearFlg)
    {
        PlayerPrefs.SetInt("ClearFlgStage" + _stageId.ToString(), _clearFlg);
        PlayerPrefs.Save();
    }
}

// public class ScriptPreferences : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
