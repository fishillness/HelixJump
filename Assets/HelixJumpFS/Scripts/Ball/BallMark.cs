using UnityEngine;

public class BallMark : BallEvents
{
    [SerializeField] private GameObject mark;
    private int markNumber = 0;
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Default || type == SegmentType.Trap)
        {
            GameObject gameObjectite = Instantiate(mark, ballController.LastCollider.transform);

            float x = ballController.gameObject.transform.position.x;
            float y = ballController.gameObject.transform.position.y;
            float z = ballController.gameObject.transform.position.z;

            gameObjectite.transform.position = new Vector3(x, y + 0.6f, z);
            gameObjectite.name = "mark" + markNumber;
            markNumber++;
        }

        if (type == SegmentType.Trap || type == SegmentType.Finish)
            markNumber = 0;
    }

}
