using System.Collections;
using System.Collections.Generic;
// using UnityEditor.UIElements;
using UnityEngine;

public class GraphToScript : MonoBehaviour
{

    public void clearStage(int _stageId, float _clearTime)
    {
        Preferences.setBestTime(_stageId - 1, _clearTime);
        Preferences.setClearFlg(_stageId - 1, 1);
    }

    public float getBestTime(int _stageId)
    {
        return Preferences.getBestTime(_stageId - 1);
    }
    public int getClearFlg(int _stageId)
    {
        return Preferences.getClearFlg(_stageId - 1);
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
