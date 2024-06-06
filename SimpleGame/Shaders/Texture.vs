#version 330

in vec3 a_Position;

out vec2 v_TexPos;

uniform vec2 u_ScreenResol;
uniform vec2 u_Position;
uniform vec2 u_Size;

void main()
{
	vec2 newPos = a_Position.xy*(u_Size/u_ScreenResol)*2 + ((u_Position/u_ScreenResol)*2-1);
	vec4 newPosition = vec4(newPos, 0, 1);
	gl_Position = newPosition;
	v_TexPos = vec2(a_Position.x , a_Position.y);
}