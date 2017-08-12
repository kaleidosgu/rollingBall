using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
    public float moveSpeed;
    public float jumpSpeed;
    public KeyCode rightDir;
    public KeyCode leftDir;
    public KeyCode jumpAction;

    private Rigidbody2D rigid;
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        bool bLeft = Input.GetKey(leftDir);
        bool bRight = Input.GetKey(rightDir);
        bool bJump = Input.GetKey(jumpAction);

        if( bLeft == true )
        {
            rigid.AddForce(Vector2.left * moveSpeed );
        }
        if( bRight == true )
        {
            rigid.AddForce(Vector2.right * moveSpeed);
        }

        if( bJump == true )
        {
            rigid.AddForce(Vector2.up * jumpSpeed);
        }
    }
}
