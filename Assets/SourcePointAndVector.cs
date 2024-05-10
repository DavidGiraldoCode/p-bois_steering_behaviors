using UnityEngine;

public class SourcePointAndVector : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject arrowGumble;
    [SerializeField] private GameObject sourcePointController;
    [SerializeField] private GameObject sourceVectorController;

    private Vector3 _sourcePoint;
    public Vector3 SourcePoint => _sourcePoint != null ? _sourcePoint : Vector3.zero;
    private Vector3 _sourceVector;
    public Vector3 SourceVector => _sourceVector != null ? _sourceVector : Vector3.zero;
    void Awake()
    {
        if (arrowGumble && sourcePointController && sourceVectorController)
        {
            
            //Debug.Log("sourceVector: " + sourceVectorController.transform.localPosition);
            _sourcePoint = sourcePointController.transform.position;
            Debug.DrawLine(sourcePointController.transform.position, sourceVectorController.transform.position, Color.red);
            _sourceVector = _sourcePoint - sourceVectorController.transform.position;
            //Debug.Log("orientation: " + _sourceVector);
            Quaternion rotation = Quaternion.LookRotation(_sourceVector, Vector3.forward);
            sourceVectorController.transform.rotation = rotation;

            //Debug.Log("============ Source Vector: " + _sourceVector);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (arrowGumble && sourcePointController && sourceVectorController)
        {
            _sourcePoint = sourcePointController.transform.position;
            Debug.DrawLine(_sourcePoint, sourceVectorController.transform.position, Color.red);
            _sourceVector = _sourcePoint - sourceVectorController.transform.position;
            Quaternion rotation = Quaternion.LookRotation(_sourceVector, Vector3.forward);
            sourceVectorController.transform.rotation = rotation;
        }
    }
}