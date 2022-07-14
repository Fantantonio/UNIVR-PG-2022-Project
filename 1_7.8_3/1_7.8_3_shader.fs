#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
	// interpolazione lineare tra le due texture (80%/20%)
	FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);
}