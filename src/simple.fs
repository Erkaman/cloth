in vec3 fsPos;
out vec3 color;

void main()
{
	//color = doSpecularLight(fsNormal, fsPos, uView);
	color = fsPos;
}
