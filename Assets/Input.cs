using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0; // Zç¿ïWÇÕ2DÇÃèÍçáå≈íËílÇ…Ç∑ÇÈ
            player.GetComponent<Player>().ClickMove(worldPosition);
        }

    }
}
