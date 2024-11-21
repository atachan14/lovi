using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float ScrollSize = 10;
    private bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveCamera(Vector3 direction)
    {
        if (!isMoving)
        {
            StartCoroutine(MoveCameraSmoothly(direction));
        }
    }

    private IEnumerator MoveCameraSmoothly(Vector3 direction)
    {
        isMoving = true; // �ړ����t���O���I��
        Vector3 startPosition = transform.position; // �J�n�ʒu
        Vector3 targetPosition = startPosition + direction * ScrollSize; // �ڕW�ʒu
        float duration = 0.2f; // �ړ��ɂ����鎞��
        float elapsed = 0f;

        // 0.5�b�����Ĉړ�
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime; // �o�ߎ��Ԃ��X�V
            float t = elapsed / duration; // �o�ߎ��Ԃ̊���
            transform.position = Vector3.Lerp(startPosition, targetPosition, t); // ���`��Ԃňړ�
            yield return null; // �t���[�����Ƃɑҋ@
        }

        transform.position = targetPosition; // �ŏI�ʒu��␳
        isMoving = false; // �ړ����t���O���I�t
    }
}