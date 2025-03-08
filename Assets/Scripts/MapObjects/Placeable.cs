using UnityEngine;

public class Placeable : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;

    private int row, column;
    private float currentHealth;

    public (int, int) Coordinates { get { return (row, column); } }
    public float CurrentHealth { get { return currentHealth; } }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset() {
        currentHealth = maxHealth;
    }
}
