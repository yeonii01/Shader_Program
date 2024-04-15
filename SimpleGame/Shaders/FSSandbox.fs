#version 330

layout(location=0) out vec4 FragColor;

uniform float u_Time;
in vec4 v_Color;

const float c_PI = 3.141592;

void FilledCircle()
{
	vec4 newColor = vec4(1,1,1,1);
	float r = 0.5;
	vec2 center = vec2(0.5, 0.5);
	float dist = distance(v_Color.rg, center);
	if(dist < r)
	{
		newColor = vec4(1,1,1,1);
	}
	else
	{
		newColor = vec4(0,0,0,0);
	}
	FragColor = newColor;
}

void Circle()
{
	vec4 newColor = vec4(1,1,1,1);
	float r = 0.5;
	float width = 0.05;

	vec2 center = vec2(0.5, 0.5);
	float dist = distance(v_Color.rg, center);
	if(dist > r - width && dist < r)
	{
		newColor = vec4(1,1,1,1);
	}
	else
	{
		newColor = vec4(0,0,0,0);
	}
	FragColor = newColor;
}

void Circles()
{
	float circleCount = 10;
	vec2 circleCenter = vec2(0.5, 0.5);
	float dist = distance(v_Color.rg, circleCenter);
	float Input = circleCount*c_PI*4 * dist - u_Time * 10.0;
	float sinValue = pow(sin(Input),16);
	FragColor = vec4(sinValue);
}

void main()
{
	 //Circle();
	 Circles();
}