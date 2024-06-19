using EFT.Visual;
using UnityEngine;

[ExecuteInEditMode]
public class CullingLightObject : CullingObject
{
	[SerializeField]
	private Light _light;

	[SerializeField]
	private float _fadeStartDistance = 50f;

	[SerializeField]
	private float _fadeEndDistance = 80f;

	[SerializeField]
	private AnimationCurve _fadeCurve = AnimationCurve.EaseInOut(0f, 1f, 1f, 0f);

	[SerializeField]
	private bool _useLightIntensityFromEditor;

	[Range(0f, 8f)]
	[SerializeField]
	private float _maxLightIntensity = 5f;

	[SerializeField]
	private bool _takeFlareParametersFromThisScript;

	private GUIStyle guistyle_0 = new GUIStyle();

	[Header("Shadows")]
	[SerializeField]
	private bool _cullShadowsByDistance = true;

	[SerializeField]
	private float _shadowsFadeStartDistance = 12f;

	[SerializeField]
	private float _shadowsFadeEndDistance = 17f;

	private float float_1;

	private bool bool_2 = true;

	private float float_2 = 1f;

	private static int int_1;

	private int int_2;

	private int int_3;

	private const int int_4 = 20;

	private float float_3;

	private float float_4;

	private float float_5;

	private LightFlicker lightFlicker_0;

	private VolumetricLight volumetricLight_0;

	private float float_6;

	private float float_7;

	private float float_8;

	[SerializeField]
	private LightShadows _initialShadowsMode;

	public float IntensityMultiplier
	{
		get
		{
			return float_2;
		}
		set
		{
			float_2 = value;
		}
	}

	public float CurrentLightIntensity => _maxLightIntensity * float_2;

	public bool IsLightEnabled => bool_2;

	public bool TakeFlareParametersFromCullingLight => _takeFlareParametersFromThisScript;

	public bool CullShadowsByDistance => _cullShadowsByDistance;
}
