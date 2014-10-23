Shader "GUI/3D Text Shader - Cull Back" {
	Properties {
		_MainTex ("Font Texture", 2D) = "white" {}
		_Color ("Text Color", Color) = (1,1,1,1)
	}
 
	SubShader {
		Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
		Lighting Off Cull Back ZWrite Off Fog { Mode Off }	ZTest LEqual
		Blend SrcAlpha OneMinusSrcAlpha
		Offset -1, -1
		Alphatest Greater 0
		Pass {
			Color [_Color]
			SetTexture [_MainTex] {
				combine primary, texture * primary
			}
		}
	}
}