using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltedEffectController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public PlayerStatus pSta;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTransparency(float alpha)
    {
        // alpha�l��0�`1�ɐ���
        alpha = Mathf.Clamp01(alpha);

        // �F�̃A���t�@�l��ύX
        Color color = spriteRenderer.color;
        color.a = alpha;
        spriteRenderer.color = color;
    }
}
