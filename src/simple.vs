layout(location = 0) in vec3 vsPos;
layout(location = 1) in vec3 vsNormal;

out vec3 fsPos;
out vec3 fsNormal;
out vec3 fsResult;

uniform mat4 uMvp;
uniform mat4 uView;

void main()
{
    fsPos = vsPos;
	fsNormal = vsNormal;
   
    gl_Position = uMvp * vec4(vsPos, 1.0);
}
