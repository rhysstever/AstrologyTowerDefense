using UnityEngine;

public class PlaceableHolder : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private bool isHoveredOver;
    private Placeable currentPlaceable;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer.color = Color.gray;
        isHoveredOver = false;
        currentPlaceable = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.GameState == GameState.Game && currentPlaceable == null && isHoveredOver) {
            if(Input.GetKeyDown(KeyCode.Space) && PlaceableManager.instance.CurrentSelectedPlaceable != null) {
                CreatePlaceable(PlaceableManager.instance.CurrentSelectedPlaceable);
            }
        }
    }

    private void OnMouseEnter() {
        isHoveredOver = true;
        spriteRenderer.color = Color.green;
    }

    private void OnMouseExit() {
        isHoveredOver = false;
        spriteRenderer.color = Color.gray;
    }

    private void CreatePlaceable(GameObject placeablePrefab) {
        Instantiate(placeablePrefab, transform.position, Quaternion.identity, transform);
    }
}
