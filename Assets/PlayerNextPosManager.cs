using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNextPosManager : MonoBehaviour
{
    public PlayerController pController;
    public GameObject pClickMoveEffect;
    public GameObject pClickMoveMark;

    public GameObject pCMM;
    private float NextPos;

    private Vector3 pNextPos;
    // Start is called before the first frame update
    void Start()
    {
        pCMM = Instantiate(pClickMoveMark, transform.position, Quaternion.identity);
        pCMM.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickMoveQol(Vector3 nextPos)
    {
        transform.position = nextPos;

        Instantiate(pClickMoveEffect, nextPos, Quaternion.identity);
        pCMM.transform.position = nextPos;
        pCMM.SetActive(true);
    }

    public void ClickMoveEnd()
    {
        pCMM.SetActive(false);
    }
}
