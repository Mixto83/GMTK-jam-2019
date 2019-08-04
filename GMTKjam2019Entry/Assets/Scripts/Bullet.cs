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
        deactivate();
	}

    #endregion

    #region Methods

    public void shoot(Vector3 pos, float angle)
    {
        gameObject.SetActive(true);
        isActive = true;
        this.transform.position = new Vector3(pos.x, pos.y, 0.0f);
        GetComponent<Rigidbody2D>().rotation = angle;
        GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0.0f, speed));
    }

    public void deactivate()
    {

        this.transform.position = new Vector3(0, 0, 0);
        gameObject.SetActive(false);
        isActive = false;
    }

    #endregion
}
