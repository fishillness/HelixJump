using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform axis;
    [SerializeField] private Floor floorPrefab;

    [Header("Settings")]
    [SerializeField] private int defaultFloorAmount;
    [SerializeField] private float floorHeight;

    public Transform BALLTRANSFORM;

    private float floorAmount = 0;

    private void Start()
    {
        Generate(1);
        BALLTRANSFORM.position = new Vector3(BALLTRANSFORM.position.x, floorAmount * floorHeight - floorHeight, BALLTRANSFORM.position.z);
    }

    public void Generate(int level)
    {
        DestroyChild();
        floorAmount = defaultFloorAmount + level;
        axis.transform.localScale = new Vector3(1, floorAmount * floorHeight + floorHeight, 1);
        
        for(int i = 0; i < floorAmount; i++)
        {
            Floor floor = Instantiate(floorPrefab, transform);
            floor.transform.Translate(0, i * floorHeight, 0);
            floor.name = "Floor " + i;
        }
    }

    private void DestroyChild()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i) == axis) continue;

            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
