using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScriptPanelControl : MonoBehaviour
{
    #region public variables
    [SerializeField] List<GameObject> panelObjects = new List<GameObject>();
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        var _sceneId = 0;
        foreach (var _panelObjects in panelObjects)
        {
            if( _sceneId == 0)
            {
                _panelObjects.SetActive(true);
            }
            else
            {
                var _clearFlg = Preferences.getClearFlg(_sceneId - 1);
                if(_clearFlg != 0)
                {
                    _panelObjects.SetActive(true);
                }
                else
                {
                    _panelObjects.SetActive(false);
                }
            }
            ++_sceneId;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
