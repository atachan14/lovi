using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QolScript : MonoBehaviour
{
    public PlayerController pController;
    public GameObject pClickMoveEffect;
    public GameObject pNextPosMark;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pNextPosMark, pController.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerClickMoveEffect(Vector3 worldPosition)
    {
        Instantiate(pClickMoveEffect, worldPosition, Quaternion.identity);

        if (!pController.GetIsMoving()) pNextPosMark.SetActive(false);
        if (pController.GetIsMoving()) pNextPosMark.SetActive(true);
        pNextPosMark.transform.position = pController.getNextPos();

        
    }
}
