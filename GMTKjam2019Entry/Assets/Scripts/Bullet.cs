using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    #region Variables

    public float speed = 0.1f;
    public bool isActive = false;
    public int bounces = 0;

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
        GetComponent<Rigidbody2D>().rotation = angle;
        GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0.0f, speed));
    }

    public void deactivate()
    {
        this.transform.position = new Vector3(5000, 5000, 5000);
        isActive = false;
        bounces = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bounces++;
    }

    #endregion
}
