#include"..\Common\DataStructs.hlsl"
#include"..\Common\Common.hlsl"
SamplerState NormalSampler
{
    Filter = MIN_MAG_MIP_LINEAR;
    AddressU = Wrap;
    AddressV = Wrap;
};

Texture2D billboardTexture : register(t0); // billboard text image

static const uint BillboardSingleText = 1;
static const uint BillboardMultiText = 2;
static const uint BillboardImage = 4;

float4 main(PSInputBT input) : SV_Target
{
	// Take the color off the texture, and use its red component as alpha.
    float4 pixelColor = billboardTexture.Sample(NormalSampler, input.t);
    float4 blend = input.foreground * pixelColor.x + input.background * (1 - pixelColor.x);
    return blend * whengt(((BillboardMultiText & (uint) vParams.y) | (BillboardSingleText & (uint) vParams.y)), 0) + pixelColor * whengt((BillboardImage & (uint) vParams.y), 0);
}