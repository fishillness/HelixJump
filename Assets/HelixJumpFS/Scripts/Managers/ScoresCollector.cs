using UnityEngine;

public class ScoresCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private int scores;
    public int Scores => scores;
    private int emptySegmentCombo = 1;
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            scores += levelProgress.CurrentLevel * emptySegmentCombo;
            emptySegmentCombo++;
        }
        if (type != SegmentType.Empty)
        {
            emptySegmentCombo = 1;
        }
    }

}
