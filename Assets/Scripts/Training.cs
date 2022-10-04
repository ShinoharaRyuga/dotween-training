using DG.Tweening;
using UnityEngine;

public class Training : MonoBehaviour
{
    [SerializeField] Transform _endPoint = default;
    [SerializeField] Transform _startPoint = default;
    [SerializeField] GameObject _target1 = default;
    [SerializeField] GameObject _target2 = default;

    float _number = 0.0f;
    float _targetValue = 10.0f;
    float _time = 0.0f;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            DOTween.To(
                () => _number,
                (x) => _number = x,
                _targetValue,
                _time);

            Debug.Log(_number);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            this.transform.DOMove(_endPoint.position, 1f);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            _target1.transform.DOJump(_endPoint.position, jumpPower: 4f, numJumps: 1, duration: 1f);
            _target2.transform.DOJump(_startPoint.position, jumpPower: -4f, numJumps: 1, duration: 1f);
        }
    }
}
