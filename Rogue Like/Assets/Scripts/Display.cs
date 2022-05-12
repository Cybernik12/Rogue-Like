using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Display : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI display;
    [SerializeField] private CharacterStats characterStats;

    // Start is called before the first frame update
    void Start()
    {
        characterStats = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterStats>();
    }

    // Update is called once per frame
    void Update()
    {
        display.text = "Hearts: " + characterStats.currentHealth;
    }
}
