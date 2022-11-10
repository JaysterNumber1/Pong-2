using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Input input;
    [SerializeField]
    private Vector2 move;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float speedMod = 1;



    private void Awake()
    {
        input = new Input();
        input.Enable();


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
