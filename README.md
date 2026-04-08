# 🥷 Unity 2D Ninja Animation Project

Este proyecto es una exploración técnica centrada en la animación 2D dentro de Unity. El objetivo principal es la implementación de un sistema de rigging (huesos) para un prefab 2D de un personaje Ninja, y el control fluido de sus estados de animación mediante el componente `Animator`.

## 🎮 Características Principales

* **Rigging 2D:** Implementación de un esqueleto personalizado para el sprite del Ninja, permitiendo deformaciones y movimientos naturales sin necesidad de dibujar cada frame (Sprite Swap).
* **Sistema de Estados (Animator):** Uso avanzado de la máquina de estados de Unity para transiciones suaves entre animaciones basadas en el input del jugador.

## 🎬 Animaciones Implementadas

El personaje cuenta con tres animaciones principales construidas a partir de la manipulación de sus huesos:

1. **Idle (Reposo):** Animación base con una respiración sutil para mantener al personaje vivo mientras no hay input.
2. **Correr:** Ciclo de caminata/carrera ajustado para dar una sensación de agilidad y velocidad.
3. **Saltar (🌟 Destacado):** Para darle un mayor dinamismo visual al salto, **los huesos de los brazos fueron rotados específicamente en el eje Z**. Esto logra un efecto visual donde el ninja alza los brazos impulsándose hacia arriba, dándole mucho más peso y realismo a la acción de saltar.

## ⚙️ Lógica del Animator

Para asegurar que cada animación se reproduzca en el momento exacto en que el jugador lo desea, el `Animator Controller` fue configurado con variables (parámetros) específicas. 

Estas variables (como pueden ser `isRunning` de tipo Booleano, o `yVelocity` de tipo Float) son evaluadas en tiempo real mediante scripts. Esto nos permite:
* Cambiar de *Idle* a *Correr* en el instante en que se detecta movimiento horizontal.
* Activar la animación de *Salto* tan pronto como se presiona el botón, y evaluar la caída para volver al estado *Idle* al tocar el suelo de forma natural.

## 🛠️ Tecnologías Usadas
* **Motor:** Unity (2D)
* **Paquetes:** 2D Animation Package

---
*Proyecto creado para profundizar en el flujo de trabajo de animación 2D y el manejo de variables del Animator en Unity.*
