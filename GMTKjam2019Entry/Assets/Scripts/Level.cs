using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

    #region Variables

    public int ID;
    public Player player;
    public List<Enemy> enemies;
    public int nActiveEnemies;

    #endregion

    #region Properties


    #endregion

    #region MonoBehaviour Functions
    // Use this for initialization
    void Start () {
        nActiveEnemies = enemies.Count;
	}
	
	// Update is called once per frame
	void Update () {

        if (nActiveEnemies <= 0)
        {
            nextLevel();
        }

        Vector3 bulletPos = player.bullet.transform.position;
        if (bulletPos.x > 9 || bulletPos.x < -9 || bulletPos.y > 5 || bulletPos.y < -5)
        {
            resetLevel();
        }

        if (player.bullet.isActive)
        {
            checkCollisions();
        }

        
	}
    #endregion

    #region Methods

    void checkCollisions()
    {
        Collider2D bulletCol = player.bullet.GetComponent<Collider2D>();
        foreach(Enemy enemy in enemies)
        {
            if (!enemy.isDead && bulletCol.bounds.Intersects(enemy.GetComponent<Collider2D>().bounds))
            {
                enemy.kill();
                nActiveEnemies--;
            }
        }
        
    }

    void resetLevel()
    {
        foreach(Enemy enemy in enemies)
        {
            enemy.respawn();
        }
        nActiveEnemies = enemies.Count;
        player.bullet.deactivate();
    }

    void nextLevel()
    {
        SceneManager.LoadScene(ID + 1);

    }

    #endregion
}
