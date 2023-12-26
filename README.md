# unity-ui-templates
Useful UI templates and tools for Unity.

## Key Features
* Button Prefabs: Main Menu, Play Again, Play, Quit
* Menu Prefabs: Lose, Main Menu, Pause, Win
* Progress bars: Radial
* Extra Scripts: 
  * UITemplates - Utilities Class
  * LookAtCamera - For world space UI
  * Pause Menu - Configurable toggle key
  * PercentageText - For displaying progress bar value as percentage

## UITemplates Methods

### LerpFillAmount
*Returns an interpolated float for the fill amount of an Image. (Use in Update loop).*
```cs
public static float LerpFillAmount(float currentFillNormalized, float targetFillNormalized)
```

### LerpColor
*Returns an interpolated Color for an Image. (Use in Update loop).*
```cs
public static Color LerpColor(float currentValueNormalized, params Color32[] colors)
```

### GetCurrentValueNormalized
*Returns the normalization of currentValue in relation to maxValue.*
```cs
public static float GetCurrentValueNormalized(float currentValue, float maxValue)
```

## Dependencies
* TextMeshPro
