using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    #region Variables

    public bool isDead = false;
    

    #endregion


    #region Methods

    public void kill()
    {
        isDead = true;
        gameObject.SetActive(false);
    }

    public virtual void respawn()
    {
        gameObject.SetActive(true);
        isDead = false;
    }

    #endregion
}
