using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotate;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.parent = transform;
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (movement != 0)
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        if (rotate != 0)
            tankController.Rotate(rotate, tankController.GetTankModel().rotationSpeed);
    }
    void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
    }
    public Rigidbody GetRigidbody()
    {
        return rb;
    }
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
