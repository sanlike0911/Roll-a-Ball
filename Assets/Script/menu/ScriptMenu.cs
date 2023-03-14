using System.Collections;
using System.Collections.Generic;
// using UnityEditor.SceneManagement;
// using UnityEditor.UIElements;
using UnityEngine;
using TMPro;

public class ScriptMenu : MonoBehaviour
{
    #region public variables
    public List<TextMeshProUGUI> labelBestTime = new List<TextMeshProUGUI>();
    #endregion

    public void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        for (int _stageId = 0; _stageId < Preferences.StageIdMax; _stageId++)
        {
            if (labelBestTime[_stageId] != null)
            {
                labelBestTime[_stageId].GetComponent<TextMeshProUGUI>().text = Preferences.getBestTime(_stageId).ToString();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
