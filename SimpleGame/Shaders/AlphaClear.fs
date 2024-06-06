#version 330

layout(location=0) out vec4 FragColor;

uniform vec4 u_Color;

in vec2 v_TexPos;

uniform sampler2D u_Texture;

void main()
{
	//FragColor = vec4(1,0,0,1);
	FragColor = u_Color;
}
