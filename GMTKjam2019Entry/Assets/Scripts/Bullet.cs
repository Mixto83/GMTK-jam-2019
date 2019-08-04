using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    #region Variables

    public float speed = 0.1f;
    public bool isActive = false;

    #endregion

    #region MonoBehaviour

    void Start () {
        isActive = false;
        deactivate();
	}
	
	void Update ()
    {

	}

    #endregion

    #region Methods

    public void shoot(Vector3 pos, float angle)
    {
        isActive = true;
        this.transform.position = new Vector3(pos.x, pos.y, 0.0f);
        //this.transform.eulerAngles = new Vector3(0.0f, 0.0f, angle);
        GetComponent<Rigidbody2D>().rotation = angle;
        GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0.0f, speed));
    }

    public void deactivate()
    {
        this.transform.position = new Vector3(5000, 5000, 5000);
        isActive = false;
    }

    #endregion
}
