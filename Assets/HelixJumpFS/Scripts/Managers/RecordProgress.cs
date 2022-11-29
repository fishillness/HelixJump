using UnityEngine;

public class RecordProgress : BallEvents
{
    [SerializeField] private ScoresCollector scoresCollector;
    private int record = 0;
    public int Record => record;
    protected override void Awake()
    {
        base.Awake();

        Load();
    }
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Finish && scoresCollector.Scores > record)
        {
            record = scoresCollector.Scores;
            Save();
        }
    }
    private void Save()
    {
        PlayerPrefs.SetInt("RecordProgress:record", record);
    }
    private void Load()
    {
        record = PlayerPrefs.GetInt("RecordProgress:record", 0);
    }
}
