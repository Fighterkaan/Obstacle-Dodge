using System.Diagnostics;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        UnityEngine.Debug.Log("Welcome to the game!");
        UnityEngine.Debug.Log("Move Using Arrow Keys or WASD");
        UnityEngine.Debug.Log("Don't bump into objects!");

        //Print Instruction
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}


