[![GitHub issues](https://img.shields.io/github/issues/MoonAntonio/GestorEscenasUnity.svg)](https://github.com/MoonAntonio/GestorEscenasUnity/issues)
[![UnityVersion](https://img.shields.io/badge/Unity-5.5.2p4-orange.svg)](https://unity3d.com/es)
[![Trello](https://img.shields.io/badge/Trello-OFF-red.svg)](https://github.com/MoonAntonio/GestorEscenasUnity)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://raw.githubusercontent.com/MoonAntonio/GestorEscenasUnity/master/LICENSE)
[![GitHub forks](https://img.shields.io/github/forks/MoonAntonio/GestorEscenasUnity.svg)](https://github.com/MoonAntonio/GestorEscenasUnity/network)
[![GitHub stars](https://img.shields.io/github/stars/MoonAntonio/GestorEscenasUnity.svg)](https://github.com/MoonAntonio/GestorEscenasUnity/stargazers)

# GestorEscenasUnity
Gestor de escenas con funcionalidad Sync para Unity3D.

## Requisitos

+ Unity3D 5.5+
+ NGUI 3.6+

---

<p align="center"><img src="https://github.com/MoonAntonio/GestorEscenasUnity/blob/master/res/preview.gif?raw=true"></p>

---

## Caracteristicas

+ Cargar escena comun
+ Cargar escena sync
+ Descargar escena
+ Cargar escena mediante editor

---

## API

* Carga la escena dada en modo Additive.
```c#
public void LoadScene(string nombre)
```
* Descarga la escena dada.
```c#
public void UnLoadScene(string nombre)
```
* Carga la escena dada asyncronamente.
```c#
public void LoadSceneAsyc(string nombre)
```
* Descarga la escena actual.
```c#
public void UnLoadActual()
```
---

## Problemas

Si no tienes NGUI, tendras que hacer la compatibilidad a UGUI, solo tienes que borrar **data.cs** y cambiar el slider de NGUI por uno de UGUI.
