using UnityEngine;

public class Generator : Placeable
{
    [SerializeField]
    private float generatedAmount, generationRate;

    private float currentGenerationTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentGenerationTimer = 0f;
    }

    void FixedUpdate()
    {
        if(GameManager.instance.GameState == GameState.Game) {
            currentGenerationTimer += Time.deltaTime;

            if(currentGenerationTimer >= generationRate) {
                ProduceCurrency();
                currentGenerationTimer = 0f;
            }
        }
    }

    private void ProduceCurrency() {
        // TODO: Instantiate currencyPrefab (from GameManager)
    }
}
