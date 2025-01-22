using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    [SerializeField] private StageData stageData;
    private ObjectMove objectMove;
    public GameOver gameOver;
    public static int playerGas = 100;

    private void Awake()
    {
        objectMove = GetComponent<ObjectMove>();
    }

    private void Start()
    {
        StartCoroutine(GasDecress());
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        objectMove.Moveto(new Vector3(x, y, 0));
        if (playerGas <= 0)
        {
            Debug.Log("Game Over");
            playerGas = 100;
            gameOver.SceneChange();
        }
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x), 
            Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }
    
    IEnumerator GasDecress()
    {
        while (true)
        {
            playerGas -= 10;
            Debug.Log("Gas : "+ playerGas);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
