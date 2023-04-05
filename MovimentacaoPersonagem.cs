using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoPersonagem : MonoBehaviour
{
    [SerializeField] private float speed; //Velocidade
    [SerializeField] private float yVelocity; //Gravidade
    CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    
    //Movimentação e Gravidade
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(horizontal, yVelocity, vertical);

        cc.Move(direcao * speed * Time.deltaTime);
    }
}
