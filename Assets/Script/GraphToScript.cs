using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphToScript : MonoBehaviour
{
    public void PublicMethod()
        => Debug.Log(nameof(PublicMethod));

    private void PrivateMethod()
        => Debug.Log(nameof(PrivateMethod));

    protected void ProtectedMethod()
        => Debug.Log(nameof(ProtectedMethod));

    public static void PublicStaticMethod()
        => Debug.Log(nameof(PublicStaticMethod));

    public static void PrivateStaticMethod()
        => Debug.Log(nameof(PrivateStaticMethod));

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
