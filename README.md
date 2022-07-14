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
Genera una finestra

<img src="/media/1_4.4.png" alt="1_4.4" width="350"/>

---

#### Window: 4.6
[1_4.6.cpp](1_4.6.cpp)<br>
Genera una finestra con colore di sfondo

<img src="/media/1_4.6.png" alt="1_4.6" width="350"/>

---

#### Draw: 5.5.2
[1_5.5.2.cpp](1_5.5.2.cpp)<br>
Utilizza gli shader per disegnare un triangolo in finestra

<img src="/media/1_5.5.2.png" alt="1_5.5.2" width="350"/>

---

#### Draw: 5.6
[1_5.6.cpp](1_5.6.cpp)<br>
Generare un rettangolo composto da due triangoli (visuale wireframe)

<img src="/media/1_5.6.png" alt="1_5.6" width="350"/>

---

#### Draw: 5.8 Esercizio 1
[1_5.8_1.cpp](1_5.8_1.cpp)<br>
Disegna due triangoli vicini usando `glDrawArrays` aggiungendo più vertici ai dati

<img src="/media/1_5.8_1.png" alt="1_5.8_1" width="350"/>

---

#### Draw: 5.8 Esercizio 2
[1_5.8_2.cpp](1_5.8_2.cpp)<br>
Disegna due triangoli vicini usando due VAO e VBO diversi per i loro dati

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
Utilizzo della classe shader e divisione in file di vertex shader e fragment shader

<img src="/media/1_6.6.png" alt="1_6.6" width="350"/>

---

#### Shaders: 6.8 Esercizio 1
[1_6.8_1](1_6.8_1)<br>
Modifica del vertex shader per capovolgere il triangolo

<img src="/media/1_6.8_1.png" alt="1_6.8_1" width="350"/>

---

#### Shaders: 6.8 Esercizio 2
[1_6.8_2](1_6.8_2)<br>
Utilizzo di un offset passato come parametro uniform per spostare il triangolo a destra dal vertex shader

<img src="/media/1_6.8_2.png" alt="1_6.8_2" width="350"/>

---

#### Shaders: 6.8 Esercizio 3
[1_6.8_3](1_6.8_3)<br>
Utilizzo della posizione del vertice come parametro RGB

<img src="/media/1_6.8_3.png" alt="1_6.8_3" width="350"/>

---

#### Textures: 7.0
[1_7.0](1_7.0)<br>
Aggiunge la texture wall.jpg al triangolo

<img src="/media/1_7.0.png" alt="1_7.0" width="350"/>

---

#### Textures: 7.6
[1_7.6](1_7.6)<br>
Aggiunge la texture container.jpg al rettangolo

<img src="/media/1_7.6.png" alt="1_7.6" width="350"/>

---

#### Textures: 7.6.1
[1_7.6.1](1_7.6.1)<br>
Aggiunge la texture container.jpg al rettangolo ed interpola il colore con la posizione dei vertici

<img src="/media/1_7.6.1.png" alt="1_7.6.1" width="350"/>

---

#### Textures: 7.7
[1_7.7](1_7.7)<br>
Mix di due texture con valore 50%/50%

<img src="/media/1_7.7.png" alt="1_7.7" width="350"/>

---

#### Textures: 7.8 Esercizio 1
[1_7.8_1](1_7.8_1)<br>
Inverte solo la texture awesomeface.png

<img src="/media/1_7.8_1.png" alt="1_7.8_1" width="350"/>

---

#### Textures: 7.8 Esercizio 2
[1_7.8_2](1_7.8_2)<br>
Replica solo la texture awesomeface.png (4 totali)

<img src="/media/1_7.8_2.png" alt="1_7.8_2" width="350"/>

---

#### Textures: 7.8 Esercizio 3
[1_7.8_3](1_7.8_3)<br>
Utilizza solo la posizione centrale della texture come texture

<img src="/media/1_7.8_3.png" alt="1_7.8_3" width="350"/>

---

#### Textures: 7.8 Esercizio 4
[1_7.8_4](1_7.8_4)<br>
Aumenta/riduce la percentuale di mix delle due texture con l'uso delle frecce da tastiera

<img src="/media/1_7.8_4.gif" alt="1_7.8_4" width="350"/>
