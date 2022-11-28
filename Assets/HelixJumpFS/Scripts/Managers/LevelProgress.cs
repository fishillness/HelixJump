using UnityEngine;

public class LevelProgress : BallEvents
{
    private int currentLevel = 1;
    public int CurrentLevel => currentLevel;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Finish)
        {
            currentLevel++;
        }
    }
}
