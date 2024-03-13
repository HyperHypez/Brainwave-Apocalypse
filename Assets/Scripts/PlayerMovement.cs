using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// adding namespaces
// because we are using the NetworkBehaviour class
// NewtorkBehaviour class is a part of the Unity.Netcode namespace
// extension of MonoBehaviour that has functions related to multiplayer
//al was here 
public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    public float jumpForce = 5f;
    // create a list of colors
    public List<Color> colors = new List<Color>();

    // getting the reference to the prefab
    private GameObject spawnedPrefab;
    // save the instantiated prefab
    private GameObject instantiatedPrefab;

    public GameObject cannon;
    public GameObject bullet;

    // reference to the camera audio listener
    private AudioListener audioListener;
    // reference to the camera
    private Camera playerCamera;

    // bool to see if player is grounded or not.
    private bool isGrounded;


    Rigidbody rb;
    Transform tr;

    // Start is called before the first frame update


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();

    }
    // Update is called once per frame
    void Update()
    {
        // check if the player is the owner of the object
        // makes sure the script is only executed on the owners 
        // not on the other prefabs 

        HandleMovementInput();
        HandleRotationInput();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

        if (Input.GetButtonDown("Fire1"))
        {
            // call the BulletSpawningServerRpc method
            // as client can not spawn objects
            GameObject newBullet = GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 2;
            newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1500);
        }
    }

    void HandleMovementInput()
    {


        Vector3 moveDirection = new Vector3(0, 0, 0);



        if (Input.GetKey(KeyCode.W))
        {
            moveDirection.z = +1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection.z = -1f;
        }


        transform.Translate(moveDirection * speed * Time.deltaTime);

    }

    void HandleRotationInput()
    {

        float rotationSpeed = 100.0f;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the player is grounded when colliding with a surface
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Set isGrounded to false when leaving a surface
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    void Jump()
    {
        // Apply the jump force to the player
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}