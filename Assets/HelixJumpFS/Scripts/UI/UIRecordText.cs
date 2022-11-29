using UnityEngine;
using UnityEngine.UI;

public class UIRecordText : BallEvents
{
    [SerializeField] private RecordProgress recordProgress;
    [SerializeField] private Text recordText;

    private void Start()
    {
        recordText.text = "������: " + recordProgress.Record.ToString();
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Finish)
        {
            recordText.text = "������: " + recordProgress.Record.ToString();
        }
    }
}
