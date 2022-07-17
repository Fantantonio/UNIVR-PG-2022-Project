# UNIVR-PG-2022-Project

Repository utilizzato per le esercitazioni del corso di Programmazione Grafica UNIVR<br>
![](https://img.shields.io/badge/%20-OpenGl-5586A4?style=flat-square)
![](https://img.shields.io/badge/%20-C++-00589D?style=flat-square)
![](https://img.shields.io/badge/%20-GLSL-5586A4?style=flat-square)
![](https://img.shields.io/badge/%20-GLFW-FF740B?style=flat-square)
===

## Capitolo 1

#### Window: 4.4
[1_4.4.cpp](1_4.4.cpp)<br>
Genera una finestra.

<img src="/media/1_4.4.png" alt="1_4.4" width="350"/>

---

#### Window: 4.6
[1_4.6.cpp](1_4.6.cpp)<br>
Genera una finestra con colore di sfondo.

<img src="/media/1_4.6.png" alt="1_4.6" width="350"/>

---

#### Draw: 5.5.2
[1_5.5.2.cpp](1_5.5.2.cpp)<br>
Utilizza gli shader per disegnare un triangolo in finestra.

<img src="/media/1_5.5.2.png" alt="1_5.5.2" width="350"/>

---

#### Draw: 5.6
[1_5.6.cpp](1_5.6.cpp)<br>
Generare un rettangolo composto da due triangoli (visuale wireframe).

<img src="/media/1_5.6.png" alt="1_5.6" width="350"/>

---

#### Draw: 5.8 Esercizio 1
[1_5.8_1.cpp](1_5.8_1.cpp)<br>
Disegna due triangoli vicini usando `glDrawArrays` aggiungendo più vertici ai dati.

<img src="/media/1_5.8_1.png" alt="1_5.8_1" width="350"/>

---

#### Draw: 5.8 Esercizio 2
[1_5.8_2.cpp](1_5.8_2.cpp)<br>
Disegna due triangoli vicini usando due VAO e VBO diversi per i loro dati.

<img src="/media/1_5.8_2.png" alt="1_5.8_2" width="350"/>

---

#### Draw: 5.8 Esercizio 3
[1_5.8_3.cpp](1_5.8_3.cpp)<br>
Disegna due triangoli, di cui uno di colore giallo utilizzando due programmi shader che si avvalgono di fragment shaders diversi.

<img src="/media/1_5.8_3.png" alt="1_5.8_3" width="350"/>

---

#### Shaders: 6.3
[1_6.3.cpp](1_6.3.cpp)<br>
Invio di valori dal vertex shader al fragment shader.

<img src="/media/1_6.3.png" alt="1_6.3" width="350"/>

---

#### Shaders: 6.4
[1_6.4.cpp](1_6.4.cpp)<br>
Utilizzo degli uniforms per impostare attributi che possono cambiare nel tempo e per scambiare dati tra l'applicazione e gli shaders.

<img src="/media/1_6.4.gif" alt="1_6.4" width="350"/>

---

#### Shaders: 6.5
[1_6.5.cpp](1_6.5.cpp)<br>
Specificando tre colori come attributi ai vertici del triangolo, si sfrutta l'interpolazione tra frammenti del fragment shader per ottenere il seguente risultato:

<img src="/media/1_6.5.png" alt="1_6.5" width="350"/>

---

#### Shaders: 6.6
[1_6.6](1_6.6)<br>
Utilizzo della classe shader e divisione in file di vertex shader e fragment shader.

<img src="/media/1_6.6.png" alt="1_6.6" width="350"/>

---

#### Shaders: 6.8 Esercizio 1
[1_6.8_1](1_6.8_1)<br>
Modifica del vertex shader per capovolgere il triangolo.

<img src="/media/1_6.8_1.png" alt="1_6.8_1" width="350"/>

---

#### Shaders: 6.8 Esercizio 2
[1_6.8_2](1_6.8_2)<br>
Utilizzo di un offset passato come parametro uniform per spostare il triangolo a destra dal vertex shader.

<img src="/media/1_6.8_2.png" alt="1_6.8_2" width="350"/>

---

#### Shaders: 6.8 Esercizio 3
[1_6.8_3](1_6.8_3)<br>
Utilizzo della posizione del vertice come parametro RGB.

<img src="/media/1_6.8_3.png" alt="1_6.8_3" width="350"/>

---

#### Textures: 7.0
[1_7.0](1_7.0)<br>
Aggiunge la texture wall.jpg al triangolo.

<img src="/media/1_7.0.png" alt="1_7.0" width="350"/>

---

#### Textures: 7.6
[1_7.6](1_7.6)<br>
Aggiunge la texture container.jpg al rettangolo.

<img src="/media/1_7.6.png" alt="1_7.6" width="350"/>

---

#### Textures: 7.6.1
[1_7.6.1](1_7.6.1)<br>
Aggiunge la texture container.jpg al rettangolo ed interpola il colore con la posizione dei vertici.

<img src="/media/1_7.6.1.png" alt="1_7.6.1" width="350"/>

---

#### Textures: 7.7
[1_7.7](1_7.7)<br>
Mix di due texture con valore 50%/50%.

<img src="/media/1_7.7.png" alt="1_7.7" width="350"/>

---

#### Textures: 7.8 Esercizio 1
[1_7.8_1](1_7.8_1)<br>
Inverte solo la texture awesomeface.png.

<img src="/media/1_7.8_1.png" alt="1_7.8_1" width="350"/>

---

#### Textures: 7.8 Esercizio 2
[1_7.8_2](1_7.8_2)<br>
Replica solo la texture awesomeface.png (4 totali).

<img src="/media/1_7.8_2.png" alt="1_7.8_2" width="350"/>

---

#### Textures: 7.8 Esercizio 3
[1_7.8_3](1_7.8_3)<br>
Utilizza solo la posizione centrale della texture come texture.

<img src="/media/1_7.8_3.png" alt="1_7.8_3" width="350"/>

---

#### Textures: 7.8 Esercizio 4
[1_7.8_4](1_7.8_4)<br>
Aumenta/riduce la percentuale di mix delle due texture con l'uso delle frecce da tastiera.

<img src="/media/1_7.8_4.gif" alt="1_7.8_4" width="350"/>

---

#### Textures: 8.17
[1_8.17](1_8.17)<br>
Scala e ruota il rettangolo.

<img src="/media/1_8.17.png" alt="1_8.17" width="350"/>

---

#### Textures: 8.17 Esempio 2
[1_8.17_2](1_8.17_2)<br>
Trasla il rettangolo in basso a destra e ruotalo nel tempo.

<img src="/media/1_8.17_2.gif" alt="1_8.17_2" width="350"/>

---

#### Textures: 8.19 Esercizio 1
[1_8.19_1](1_8.19_1)<br>
Ruota nel tempo il rettangolo e traslalo in basso a destra.

<img src="/media/1_8.19_1.gif" alt="1_8.19_1" width="350"/>

---

#### Textures: 8.19 Esercizio 2
[1_8.19_2](1_8.19_2)<br>
Aggiungi a 8.17 Esempio 2 un rettangolo in alto a sinistra e scalalo nel tempo.

<img src="/media/1_8.19_2.gif" alt="1_8.19_2" width="350"/>

---

#### Coordinate Systems: 9.7
[1_9.7](1_9.7)<br>
Sposta le coordinate dei vertici attraverso le matrici model, view e projection per ottenere un oggetto inclinato all'indietro, leggermente distante dall'osservatore e visualizzato con prospettiva.

<img src="/media/1_9.7.png" alt="1_9.7" width="350"/>

---

#### Coordinate Systems: 9.8
[1_9.8](1_9.8)<br>
Disegna un cubo che ruota senza abilitare le informazioni di profondità.

<img src="/media/1_9.8.gif" alt="1_9.8" width="350"/>

---

#### Coordinate Systems: 9.8.1
[1_9.8.1](1_9.8.1)<br>
9.8 con le informazioni di profondità abilitate.

<img src="/media/1_9.8.1.gif" alt="1_9.8.1" width="350"/>

---

#### Coordinate Systems: 9.8.2
[1_9.8.2](1_9.8.2)<br>
Disegna vari cubi in posizioni random con rotazione random.

<img src="/media/1_9.8.2.png" alt="1_9.8.2" width="350"/>

---

#### Coordinate Systems: 9.9 Esercizio 3
[1_9.9_3](1_9.9_3)<br>
9.8.2 ma ogni tre cubi uno ruota.

<img src="/media/1_9.9_3.gif" alt="1_9.9_3" width="350"/>

---

#### Camera: 10.2
[1_10.2](1_10.2)<br>
Implementa la rotazione nel tempo della camera attorno alla scena.

<img src="/media/1_10.2.gif" alt="1_10.2" width="350"/>

---

#### Camera: 10.4
[1_10.4](1_10.4)<br>
Implementa una camera che si muove alla stessa velocità su ogni sistema (deltaTime) (solo WASD).

<img src="/media/1_10.4.gif" alt="1_10.4" width="350"/>

---

#### Camera: 10.8
[1_10.8](1_10.8)<br>
Implementa una camera che permette di muoversi liberamente in un ambiente 3D (WASD + scroll + posizione mouse).

<img src="/media/1_10.8.gif" alt="1_10.8" width="350"/>

---

#### Camera: 10.9
[1_10.9](1_10.9)<br>
Implementa una classe camera di tipo fly.

<img src="/media/1_10.9.gif" alt="1_10.9" width="350"/>

---

#### Camera: 10.9 Esercizio 1
[1_10.9_1](1_10.9_1)<br>
La camera è di tipo FPS (mantiene l'osservatore a livello ground).

<img src="/media/1_10.9_1.gif" alt="1_10.9_1" width="350"/>

---
---

## Capitolo 2


#### Colors: 12.1
[2_12.1](2_12.1)<br>
Implementa un oggetto cubo ed un oggetto luce (cubo più piccolo).

<img src="/media/2_12.1.png" alt="2_12.1" width="350"/>

---

#### Basic Lighting: 13.4
[2_13.4](2_13.4)<br>
Utilizzo dell'illuminazione diffusa. Si noti la differenza di intensità illuminazione del cubo tanto maggiore è piccolo l'angolo tra il vettore normale e il vettore direzione della luce.

<img src="/media/2_13.4.png" alt="2_13.4" width="350"/>

---

#### Basic Lighting: 13.6
[2_13.6](2_13.6)<br>
Completa l'implementazione del sistema di illuminazione Phong nello spazio world.

<img src="/media/2_13.6.png" alt="2_13.6" width="350"/>

---

#### Basic Lighting: 13.7 Esercizio 1
[2_13.7_1](2_13.7_1)<br>
Utilizza seno e coseno per muovere la posizione della luce nel tempo.

<img src="/media/2_13.7_1.gif" alt="2_13.7_1" width="350"/>

---

#### Basic Lighting: 13.7 Esercizio 2
[2_13.7_2](2_13.7_2)<br>
Implementa il Pong shading nello spazio view invece che world.

<img src="/media/2_13.7_2.gif" alt="2_13.7_2" width="350"/>

---

#### Basic Lighting: 13.7 Esercizio 3
[2_13.7_3](2_13.7_3)<br>
Utilizzo del Gouraud shading al posto del Phong (meno preciso).

<img src="/media/2_13.7_3.png" alt="2_13.7_3" width="350"/>

---

#### Materials: 14.3
[2_14.3](2_14.3)<br>
Stesso effetto raggiunto in precedenza ma con controllo completo sulla luce e sul materiale dell'oggetto.

<img src="/media/2_14.3.gif" alt="2_14.3" width="350"/>

---

#### Materials: 14.4 Esercizio 1
[2_14.4_1](2_14.4_1)<br>
Simula il materiale plastica ciano con intensità luminosa impostata al massimo.

<img src="/media/2_14.4_1.png" alt="2_14.4_1" width="350"/>

---

#### Lighting Maps: 15.1
[2_15.1](2_15.1)<br>
Utilizzo di una diffuse map.

<img src="/media/2_15.1.png" alt="2_15.1" width="350"/>

---

#### Lighting Maps: 15.3
[2_15.3](2_15.3)<br>
Calcola la luce speculare dalla texture fornita.

<img src="/media/2_15.3.png" alt="2_15.3" width="350"/>

---

#### Lighting Maps: 15.4 Esercizio 2
[2_15.4_1](2_15.4_1)<br>
Inverte la luce speculare calcolata dalla texture.

<img src="/media/2_15.4_1.png" alt="2_15.4_1" width="350"/>

---

#### Lighting Maps: 15.4 Esercizio 3
[2_15.4_2](2_15.4_2)<br>
Utilizza una texture colorata per calcolare la luce speculare.

<img src="/media/2_15.4_2.png" alt="2_15.4_2" width="350"/>

---

#### Lighting Maps: 15.4 Esercizio 4
[2_15.4_3](2_15.4_3)<br>
Aggiunge una luce emissiva data da una texture (scritte verdi sul cubo).

<img src="/media/2_15.4_3.png" alt="2_15.4_3" width="350"/>

---

#### Lighting Maps: 16.1
[2_16.1](2_16.1)<br>
Creazione di una luce direzionale.

<img src="/media/2_16.1.png" alt="2_16.1" width="350"/>

---

#### Lighting Maps: 16.3.2
[2_16.3.2](2_16.3.2)<br>
Creazione di una luce point con attenuazione.

<img src="/media/2_16.3.2.png" alt="2_16.3.2" width="350"/>

---

#### Lighting Maps: 16.5
[2_16.5](2_16.5)<br>
Creazione di una flashlight posizionata sulla camera.

<img src="/media/2_16.5.png" alt="2_16.5" width="350"/>

---

#### Lighting Maps: 16.6
[2_16.6](2_16.6)<br>
Creazione di una flashlight con bordi attenuati.

<img src="/media/2_16.6.png" alt="2_16.6" width="350"/>

---

#### Lighting Maps: 17.3
[2_17.3](2_17.3)<br>
Crea una scena con luci multiple (ambientale, direzionale, spot e point).

<img src="/media/2_17.3.png" alt="2_17.3" width="350"/>

---
---

## Capitolo 3

#### Model: 21.3
[3_21.3](3_21.3)<br>
Importa un modello (.obj) completo di texture attraverso Assimp. Creazione di classi Mesh e Model dedicate.

<img src="/media/3_21.3.png" alt="3_21.3" width="350"/>

---
---

## Capitolo 5

#### Lighting Maps: 37.2.2
[5_37.2.2](5_37.2.2)<br>
Utilizza il normal mapping per generare dettagli a basso costo attraverso la modifica di vettori delle normali per frammento senza dover modificare l'equazione dell'illuminazione.

<img src="/media/5_37.2.2.png" alt="5_37.2.2" width="350"/>

---
---

## Esercitazione Animazione

Riproduce l'animazione scheletale del seguente repository: [skeletal_animation_tutorial](https://github.com/dinismf/skeletal_animation_tutorial/tree/master/TeapotAD).

<img src="/media/skeletal_animation.gif" alt="skeletal_animation" width="350"/>
