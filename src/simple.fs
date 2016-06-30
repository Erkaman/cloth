in vec3 fsPos;
in vec3 fsNormal;
in vec2 fsUv;

out vec3 color;

uniform sampler2D uTexture;

void main()
{
	//color = doSpecularLight(fsNormal, fsPos, uView);
	color = fsPos;
	
	vec3 lightDir = normalize(vec3(0.4, 0.4, 0.4) );
	
	vec3 n = fsNormal;
	if(!gl_FrontFacing) {
		n = -n;
	}
	
//	color = 
	
	
	vec3 tex =  texture( uTexture, fsUv ).xyz;
	
	vec3 ambient = 0.2 * tex;
	vec3 diff = 0.5 * clamp(dot(n, lightDir), 0.0, 1.0) * tex;
	
	color = ambient + diff;
	
	
}
