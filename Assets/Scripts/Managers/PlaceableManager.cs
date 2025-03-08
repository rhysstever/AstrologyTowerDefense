using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

public enum PlaceableName
{
    Generator,
    Shooter
}

public class PlaceableManager : MonoBehaviour
{
    public static PlaceableManager instance = null;

    [SerializeField]
    private GameObject generatorPrefab, shooterPrefab;

    private Dictionary<PlaceableName, GameObject> placeablesMap;
    private GameObject currentSelectedPlaceable;

    public Dictionary<PlaceableName, GameObject> PlaceablesMap { get { return placeablesMap; } }
    public GameObject CurrentSelectedPlaceable { get { return currentSelectedPlaceable; } }

    private void Awake() {
        // Singleton code
        if(instance == null)
            instance = this;

        else if(instance != this)
            Destroy(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placeablesMap = new Dictionary<PlaceableName, GameObject>();
        placeablesMap.Add(PlaceableName.Generator, generatorPrefab);
        placeablesMap.Add(PlaceableName.Shooter, shooterPrefab);

        currentSelectedPlaceable = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            currentSelectedPlaceable = placeablesMap[PlaceableName.Generator];
        } else if(Input.GetMouseButtonDown(1)) {
            currentSelectedPlaceable = placeablesMap[PlaceableName.Shooter];
        }
    }
}
