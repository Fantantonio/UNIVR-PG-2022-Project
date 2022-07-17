#version 330 core
out vec4 FragColor;

// attributi passati dal vertex come input
in VS_OUT {
    vec3 FragPos;
    vec2 TexCoords;
    vec3 Normal;
    vec3 TangentViewPos;
    vec3 TangentFragPos;
    mat3 TBN;
} fs_in;

struct Material {
    sampler2D diffuse; // componente diffusiva
    sampler2D specular; // componente speculare
    sampler2D normal;
    float shininess; // shininess del materiale
};

// strutture utilizzate dal fragment shader per il lighting

// Directional light: la direzione della luce rimane sempre la stessa 
struct DirLight {
    vec3 direction; //direzione
	
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;
};

// Point light
struct PointLight {
    vec3 position;
    
    float constant;
    float linear;
    float quadratic;
	
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;
};

// Spot light: emette luce solo nel raggio definito dallo spotlight
struct SpotLight {
    vec3 position;
    vec3 direction;
    float cutOff;
    float outerCutOff;
  
    float constant;
    float linear;
    float quadratic;
  
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;       
};

// Numero delle point light
#define NR_POINT_LIGHTS 4


// variabili uniform
uniform vec3 viewPos;
uniform DirLight dirLight;  
uniform PointLight pointLights[NR_POINT_LIGHTS]; // array delle point lights
uniform SpotLight spotLight;
uniform Material material;

// Funzioni per il calcolo delle 3 tipologie di luce (per svuotare il codice del main)
vec3 CalcDirLight(DirLight light, vec3 normal, vec3 viewDir);
vec3 CalcPointLight(PointLight light, vec3 normal, vec3 fragPos, vec3 viewDir);
vec3 CalcSpotLight(SpotLight light, vec3 normal, vec3 fragPos, vec3 viewDir);


void main()
{ 
    // Tangent space
    // calcola la normale nel tangent space
    vec3 normal = texture(material.normal, fs_in.TexCoords).rgb;
    // trasforma il vettore della normale da [0,1] a [-1,1]
    normal = normalize(normal * 2.0 - 1.0);
    
    // normale per il diffuse lighting
    vec3 norm = normalize(fs_in.Normal);
    // aggiungo la tangente
    vec3 tanViewDir = normalize(fs_in.TangentViewPos - fs_in.TangentFragPos);
    vec3 viewDir = normalize(viewPos - fs_in.FragPos); 


    // calcola il contributo di ogni luce e lo somma in result (result = colore finale del fragment)
    // Directional light
    vec3 result = CalcDirLight(dirLight, norm, viewDir);
    // Point light-> calcolo il contributo di ogni lampadina 
    for (int i = 0; i < NR_POINT_LIGHTS; i += 1) {
        result += CalcPointLight(pointLights[i], normal, fs_in.TangentFragPos, tanViewDir);
    }
    // Spot light
    result += CalcSpotLight(spotLight, norm, fs_in.FragPos, viewDir);    
    
    FragColor = vec4(result, 1.0);
}


// calcolo del colore sulla Directional Light
vec3 CalcDirLight(DirLight light, vec3 normal, vec3 viewDir)
{
    // negativa poiché va dal frammento verso la sorgente di luce
    vec3 lightDir = normalize(-light.direction); 
    // Diffuse shading 
    float diff = max(dot(normal, lightDir), 0.0); 
    // Specular shading (negativo, prende la direzione opposta)
    vec3 reflectDir = reflect(-lightDir, normal);
    // ottiene un coseno limitato a 0 ed eleva per material.shininess
    float spec = pow(max(dot(viewDir, reflectDir), 0.0), material.shininess);
    // combina i risultati
    vec3 ambient = light.ambient * vec3(texture(material.diffuse, fs_in.TexCoords));
    vec3 diffuse = light.diffuse * diff * vec3(texture(material.diffuse, fs_in.TexCoords));
    vec3 specular = light.specular * spec * vec3(texture(material.specular, fs_in.TexCoords));
    return (ambient + diffuse + specular);
}


// calcolo del colore sulla point light
vec3 CalcPointLight(PointLight light, vec3 normal, vec3 fragPos, vec3 viewDir)
{
    // posizione della luce x la matrice TBN (direzione del raggio associato ad ogni frammento)
    vec3 lightDir = normalize((fs_in.TBN * light.position) - fragPos);
    // Diffuse shading
    float diff = max(dot(normal, lightDir), 0.0); 
    // Specular shading
    vec3 reflectDir = reflect(-lightDir, normal);
    // formula luce speculare
    float spec = pow(max(dot(viewDir, reflectDir), 0.0), material.shininess);
    // Attenuazione (distanza dalla sorgente di luce)
    float distance = length((fs_in.TBN * light.position) - fragPos);
    // formula per l'attenuazione
    float attenuation = 1.0 / (light.constant + light.linear * distance + light.quadratic * (distance * distance));
    // combina i risultati
    vec3 ambient = light.ambient * vec3(texture(material.diffuse, fs_in.TexCoords));
    vec3 diffuse = light.diffuse * diff * vec3(texture(material.diffuse, fs_in.TexCoords));
    vec3 specular = light.specular * spec * vec3(texture(material.specular, fs_in.TexCoords));
    // moltiplica le componenti per l'attenuazione
    ambient *= attenuation;
    diffuse *= attenuation;
    specular *= attenuation;
    return (ambient + diffuse + specular);
}


// calcola il colore per la spot light
vec3 CalcSpotLight(SpotLight light, vec3 normal, vec3 fragPos, vec3 viewDir)
{                        
    vec3 lightDir = normalize(light.position - fragPos); 
    // Diffuse shading 
    float diff = max(dot(normal, lightDir), 0.0); 
    // Specular shading 
    vec3 reflectDir = reflect(-lightDir, normal); 
    float spec = pow(max(dot(viewDir, reflectDir), 0.0), material.shininess); 
    // Attenuazione (distanza dalla sorgente di luce)
    float distance = length(light.position - fragPos);
    // formula per l'attenuazione
    float attenuation = 1.0 / (light.constant + light.linear * distance + light.quadratic * (distance * distance));
    // calcoli per avere i bordi della spotlight smoothed
    float theta = dot(lightDir, normalize(-light.direction)); 
    float epsilon = light.cutOff - light.outerCutOff;
    float intensity = clamp((theta - light.outerCutOff) / epsilon, 0.0, 1.0);
    // combina i risultati
    vec3 ambient = light.ambient * vec3(texture(material.diffuse, fs_in.TexCoords));
    vec3 diffuse = light.diffuse * diff * vec3(texture(material.diffuse, fs_in.TexCoords));
    vec3 specular = light.specular * spec * vec3(texture(material.specular, fs_in.TexCoords));
    // moltiplica le componenti per attenuazione ed intensità
    ambient *= attenuation * intensity;
    diffuse *= attenuation * intensity;
    specular *= attenuation * intensity;
    return (ambient + diffuse + specular);
}