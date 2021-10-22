using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Rigidbody 2D raket ini
    private Rigidbody2D rigidBody2D;

    // Tombol untuk menggerakkan ke atas
    public KeyCode upButton = KeyCode.W;
 
    // Tombol untuk menggerakkan ke bawah
    public KeyCode downButton = KeyCode.S;

    // Tombol untuk menggerakkan ke kiri
    public KeyCode kiriButton = KeyCode.A;

    // Tombol untuk menggerakkan ke kanan
    public KeyCode kananButton = KeyCode.D;

    // Kecepatan gerak
    public float speed = 10.0f;   

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Dapatkan kecepatan raket sekarang.
        Vector2 velocity = rigidBody2D.velocity;
 
        // Jika pemain menekan tombol ke atas, beri kecepatan positif ke komponen y (ke atas).
        if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }
 
        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah).
        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }

        // Jika pemain menekan tombol ke kiri, beri kecepatan negatif ke komponen y (ke kiri).
        else if (Input.GetKey(kiriButton))
        {
            velocity.x = -speed;
        }

        // Jika pemain menekan tombol ke kanan, beri kecepatan positif ke komponen y (ke kanan).
        else if (Input.GetKey(kananButton))
        {
            velocity.x = speed;
        }
 
        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }
 
        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;

    
    }
}