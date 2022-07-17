#version 330 core

layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aNormal;
layout (location = 2) in vec2 aTexCoords;
layout (location = 3) in vec3 aTangent;
layout (location = 4) in vec3 aBitangent;

out VS_OUT {
    vec3 FragPos;
    vec2 TexCoords;
    vec3 Normal;
    //vec3 TangentLightPos; 
    vec3 TangentViewPos;
    vec3 TangentFragPos;
    mat3 TBN;
} vs_out;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

uniform vec3 viewPos;

void main()
{
    // calcola FragPos, TextCoords e Normal 
    vs_out.FragPos = vec3(model * vec4(aPos, 1.0)); 
    vs_out.TexCoords = aTexCoords;
    vs_out.Normal = mat3(transpose(inverse(model))) * aNormal; 


    // configura la matrice TBN, (nello spazio mondo poiché moltiplica per model)
    vec3 T = normalize(vec3(model * vec4(aTangent,   0.0)));
    vec3 B = normalize(vec3(model * vec4(aBitangent, 0.0)));
    vec3 N = normalize(vec3(model * vec4(aNormal,    0.0)));
    // inversa della matrice TBN, poiché serve per trasformare i vettori dallo spazio mondo allo spazio tangent
    // usa il transpose essendo la matrice ortogonale
    vs_out.TBN = transpose(mat3(T, B, N));
    // trasformazione dei vettori viewPos e FragPos nel Tangent
    vs_out.TangentViewPos  = vs_out.TBN * viewPos;
    vs_out.TangentFragPos  = vs_out.TBN * vs_out.FragPos;

    gl_Position = projection * view * model * vec4(aPos, 1.0);
}
