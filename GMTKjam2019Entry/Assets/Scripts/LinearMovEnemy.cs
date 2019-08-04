using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovEnemy : Enemy {

    #region Variables

    Vector3 pos0;
    public Vector3 direction;
    public float speed;
    public float maxDistance;

    #endregion

    #region MonoBehaviour
    // Use this for initialization
    void Start () {
        direction = direction.normalized;
        pos0 = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isDead)
        {
            transform.position += direction * speed;
            if (Vector3.Distance(transform.position, pos0) >= maxDistance)
            {
                transform.position = pos0 + direction * maxDistance;
                direction = -direction;
            }
        }
	}

    #endregion

    #region Methods
    public override void respawn()
    {
        base.respawn();
        this.transform.position = pos0;
    }
    #endregion
}
