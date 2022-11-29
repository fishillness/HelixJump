using UnityEngine;

public class PaletteSelection : MonoBehaviour
{
    [SerializeField] private Material axisMat;
    [SerializeField] private Material ballMat;
    [SerializeField] private Material defaultSegmentMat;
    [SerializeField] private Material finishSegmentMat;
    [SerializeField] private Material trapSegmentMat;

    private int random;
    private static int amountPalette = 3;

    [SerializeField] private Color[] axisColors = new Color[amountPalette];
    [SerializeField] private Color[] ballColors = new Color[amountPalette];
    [SerializeField] private Color[] defaultSegmentColors = new Color[amountPalette];
    [SerializeField] private Color[] finishSegmentColors = new Color[amountPalette];
    [SerializeField] private Color[] trapSegmentColors = new Color[amountPalette];


    private void Start()
    {
        ChangePalette();
    }

    public void ChangePalette()
    {

        random = Random.Range(0, amountPalette);
        axisMat.color = axisColors[random];
        ballMat.color = ballColors[random];
        defaultSegmentMat.color = defaultSegmentColors[random];
        finishSegmentMat.color = finishSegmentColors[random];
        trapSegmentMat.color = trapSegmentColors[random];
    }
}
