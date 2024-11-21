using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectController : MonoBehaviour
{
    public float fadeDuration = 2f; // �t�F�[�h�A�E�g�ɂ����鎞��
    private Renderer objectRenderer;
    private Color initialColor;

    void Start()
    {
        // �I�u�W�F�N�g��Renderer���擾
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            initialColor = objectRenderer.material.color; // ���̐F��ۑ�
            StartCoroutine(FadeOutAndDestroy());
        }
        else
        {
            Debug.LogWarning("Renderer��������܂���ł���");
            Destroy(gameObject); // Renderer���Ȃ��ꍇ�͑��j��
        }
    }

    private IEnumerator FadeOutAndDestroy()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            // ���Ԍo�߂ɉ����ăA���t�@�l������������
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            Color newColor = initialColor;
            newColor.a = alpha;
            objectRenderer.material.color = newColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // �Ō�ɃI�u�W�F�N�g��j��
        Destroy(gameObject);
    }
}