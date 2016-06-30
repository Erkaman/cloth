in vec3 fsPos;
in vec3 fsNormal;

out vec3 color;

void main()
{
	//color = doSpecularLight(fsNormal, fsPos, uView);
	color = fsPos;
	
	vec3 lightDir = normalize(vec3(0.4, 0.4, 0.4) );
	
	vec3 n = fsNormal;
	if(!gl_FrontFacing) {
		n = -n;
	}
	
	color = vec3( dot(n, lightDir) );
	
	
}
