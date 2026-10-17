# Físicas 3D
## Ejercicio 1: experimentar con las físicas
### Situación 1
> El plano no es un objeto físico. El cubo es un objeto físico y la esfera no. En este caso, el plano y la esfera sólo tendrán collider, mientras que el cubo debe tener Rigidbody. 

Como el plano no es un objeto físico, no es afectado por la gravedad, al igual que la esfera. En el caso del cubo, este cae pero es sujetado por el plano al no tener la configuración de Trigger. Tanto el plano como la esfera tienen colisiones estáticas al no ser físicos, mientras que el cubo tiene una colisión dinámica. Según la documentación de Unity, ocurre la colisión y se notifica.

### Situación 2
> El plano no es un objeto físico. El cubo es un objeto físico y la esfera también. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody. 

En este caso, al añadirle físicas a la esfera, esta cae por acción de la gravedad, colisiona con el cubo y sale del plano, cayendo al vacío. El plano sería el único con colisión estática, mientras que la esfera y el cubo tienen colisión dinámica, ocurriendo los eventos de colisión entre todos y notificándose.