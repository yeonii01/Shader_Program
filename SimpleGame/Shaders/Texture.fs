#version 330

layout(location=0) out vec4 FragColor;

in vec2 v_TexPos;

uniform sampler2D u_Texture;

void main()
{
	//FragColor = vec4(1,0,0,1);
	FragColor = texture(u_Texture, v_TexPos);
}
