using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    #region Variables
    public float speed;
    public float turnspeed;
    public float fwdInput;
    public float horiInput;
    public float accelRate;
    #endregion


    #region Main Methods
    void Start()
    {
        speed = 12;
        turnspeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
 
        Move();
    }
    #endregion


    #region Utility Methods
    public void Move()
    {
        horiInput = Input.GetAxis("Horizontal");
        fwdInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fwdInput);
        if (fwdInput != 0)transform.Rotate(Vector3.up, turnspeed * horiInput * Time.deltaTime);

    }
    #endregion
}
