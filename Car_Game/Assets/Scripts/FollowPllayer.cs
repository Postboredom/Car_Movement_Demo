using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPllayer : MonoBehaviour
{
    #region Variables
    public GameObject Player;
    private Vector3 offset;
    #endregion

    #region Main Methods
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 5, -7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
    }
    #endregion

    #region Utility Methods
    #endregion
}
