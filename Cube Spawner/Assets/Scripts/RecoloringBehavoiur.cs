using UnityEngine;
using Random = UnityEngine.Random;

public class RecoloringBehavoiur : MonoBehaviour
{
    [SerializeField]
    private float _recoloringDuration = 2f;
    [SerializeField]
    private float _recoloringDelay = 2f;

    private Renderer _renderer;
    private Color _startColor;
    private Color _endColor;
    private float _recoloringTime;
    private float _recoloringSmoothing;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        GenerateNextColor();
    }

    private void Update()
    {
        _recoloringTime += Time.deltaTime;
        _recoloringSmoothing = _recoloringTime / _recoloringDuration;
        _renderer.material.color = Color.Lerp(_startColor, _endColor, _recoloringSmoothing);
        if (_recoloringTime >= _recoloringDelay + _recoloringDuration)
        {
            GenerateNextColor();
            _recoloringTime = 0f;
        }
    }

    private void GenerateNextColor()
    {
        _startColor = _renderer.material.color;
        _endColor = Random.ColorHSV(0f, 1f, 0.7f, 1f, 1f, 1f);
    }
}
