#version 330

layout(location=0) out vec4 FragColor;

uniform sampler2D u_Texture;
uniform sampler2D u_NumberTexture[10];
uniform sampler2D u_NumbersTexture;
uniform float u_Time;

in vec2 v_TexPos;

void P1()
{
	vec2 newTexPos;
	float tx = v_TexPos.x;
	float ty = fract(v_TexPos.y*2);
	newTexPos = vec2(tx, ty);
	FragColor = texture(u_Texture, newTexPos);
}

void P2()
{
	vec2 newTexPos;
	float tx = v_TexPos.x;
	float ty = 1 - abs(v_TexPos.y * 2 - 1);
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P3()
{
	vec2 newTexPos;
	float tx =  fract(v_TexPos.x*3); // 0~1, 0~1,0~1
	float ty = v_TexPos.y / 3 + (2-floor(v_TexPos.x*3))/3;
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P4()
{
	vec2 newTexPos;
	float tx =  fract(v_TexPos.x*3); // 0~1, 0~1,0~1
	float ty = v_TexPos.y / 3 + floor(v_TexPos.x*3)/3;
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P5()//시험
{
	//3분의 2 3분의 1 0 순서
	float tx = v_TexPos.x;
	float ty = (3 * v_TexPos.y - 2) / 3;
	vec2 newTexPos = vec2(tx, ty); 
	FragColor = texture(u_Texture, newTexPos);
}

void P6()
{
	float padding = 0.2 - u_Time;
	float countX = 10;
	float countY = 10;
	vec2 newTexPos;
	float tx = fract(padding*floor(v_TexPos.y*countY))+v_TexPos.x*countX;
	float ty = fract(v_TexPos.y*countY);
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P7() //시험
{
	float padding = 0.5;
	float countX = 2;
	float countY = 2;
	vec2 newTexPos;
	float tx = fract(v_TexPos.x*countX);
	float ty = fract(padding*floor(v_TexPos.x*countX))+v_TexPos.y*countY;
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_Texture, newTexPos);
}

void P8()
{
	vec2 newTexPos;
	float tx =  v_TexPos.x;
	float ty = v_TexPos.y;
	newTexPos = vec2(tx, ty);

	int texID = int(u_Time)%10;

	FragColor = texture(u_NumberTexture[texID], newTexPos);
}

void P9()
{
	vec2 newTexPos;
	float xResol = 5;
	float yResol = 2;
	float id = 5;
	float indexX = float(int(id)%int(xResol));
	float indexY = floor(int(id)/xResol);
	float tx = v_TexPos.x/5 + indexX*(1/xResol);
	float ty = v_TexPos.y/2+ indexY*(1/yResol);
	newTexPos = vec2(tx, ty);

	FragColor = texture(u_NumbersTexture, newTexPos);
}

void P10()
{
   float tx = v_TexPos.x;
   float ty = (floor(v_TexPos.y * 3) * -2 + 2) / 3 + v_TexPos.y;
   vec2 newTexPos = vec2(tx, ty);
   FragColor = texture(u_Texture, newTexPos);
}

void main()
{
	P10();
}