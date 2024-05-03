#ifndef BLUR_INCLUDED
#define BLUR_INCLUDED

//#include "Packages/com.unityt.render-pipelines.universal/ShaderLibrary/Core.hsl"

void ApplyBoxBlur3x3_float(UnityTexture2D Tex, UnitySamplerState SS,float2 Uv, float2 texelOffset, out float4 result)
{
	 result = 0;
	 [unroll(9)]
	for(int x  = -1; x < 1; x++)
	{
		for(int y = 1; y > -1;y-- )
		{
			const float2 offset = float2 (x,y);
			result += SAMPLE_TEXTURE2D(Tex,SS,Uv + float2 (x,y)* texelOffset)*0.1111
			;
		}

	}
}

void AppluSobel3x3_float(UnityTexture2D Tex, UnitySamplerState Ss, float2 Uv,float2 texelOffset, out float2 result)
{
	float3x3 sobelkernel = float3x3(
		float3 (-1,0,1),
		float3 (-2,0,2),
		float3 (-1,0,1)
		);
		float4 sobelx =0;
		float4 sobely =0;

		[unroll(9)]

	for(int y=1;y>-1;y--)
	{
		for(int x =-1;x<1;x++)
		{
			const float2 offset = float2 (x,y);
			float2 remappersOffset = offset * 0.5 +0.5 *2 ;
			sobelx +=  SAMPLE_TEXTURE2D(Tex,Ss,Uv + float2 (x,y)* texelOffset)* sobelkernel[(int)remappersOffset.y][(int)remappersOffset.x] ;
			sobely +=  SAMPLE_TEXTURE2D(Tex,Ss,Uv + float2 (x,y)* texelOffset)* transpose( sobelkernel)[(int)remappersOffset.y][(int)remappersOffset.x] ;
		}

	}
	result = sqrt (sobelx *sobelx + sobely*sobely);
}

#endif 