using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_2PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 18f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    private int count;
    public Text winText;
    public Text countText;

    private float BoostTimer;
    private bool Boosting;

    // Start is called before the first frame update
    void Start()
    {
        count = 1;
        SetCountText();
        winText.text = "";

        speed = 18;
        BoostTimer = 0;
        Boosting = false;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Boosting)
        {
            BoostTimer += Time.deltaTime;
            if (BoostTimer >= 3)
            {
                speed = 18;
                BoostTimer = 0;
                Boosting = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SpeedBoost")
        {
            Boosting = true;
            speed = 100;
            Destroy(other.gameObject);
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //if (other.gameObject.CompareTag("Pickup"))
    //{
    //other.gameObject.SetActive (false);
    //count = count + 1;
    // SetCountText();
    // }
    // }

    void SetCountText()
    {
        countText.text = "count: " + count.ToString();
        if (count >= 1)
        {
            winText.text = ("Game Over");
        }
    }
}
