using UnityEngine;

public static class UITemplates
{
    private static float _lerpSpeed = 3.0f;
    private static float _epsilon = 0.01f;

    public static float LerpFillAmount(float currentFillNormalized, float targetFillNormalized)
    {
        float newFillAmount = Mathf.Lerp(currentFillNormalized, targetFillNormalized, _lerpSpeed * Time.deltaTime);
        if (Mathf.Abs(currentFillNormalized - targetFillNormalized) <= _epsilon)
            return targetFillNormalized;
        return newFillAmount;
    }

    public static Color LerpColor(float currentValueNormalized, params Color32[] colors)
    {
        if (colors.Length < 2)
            return Color.Lerp(Color.red, Color.green, currentValueNormalized);
        return Color.Lerp(colors[0], colors[1], currentValueNormalized);
    } 

    public static float GetCurrentValueNormalized(float currentValue, float maxValue) => currentValue / maxValue;
}