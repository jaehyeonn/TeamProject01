using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StageData : MonoBehaviour
{
    [SerializeField]
    private Vector3 limitMin;
    [SerializeField]
    private Vector3 limitMax;

    public Vector3 LimitMin => limitMin;
    public Vector3 LimitMax => limitMax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
