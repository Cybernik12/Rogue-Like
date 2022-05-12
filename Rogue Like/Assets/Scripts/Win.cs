using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyRemaining();
        Winner();

        Debug.Log(enemy);
    }

    private void EnemyRemaining()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    private void Winner()
    {
        if (enemy == null)
        {
            SceneManager.LoadScene(3);
        }
    }
}
