# Físicas 3D
## Ejercicio 1: experimentar con las físicas
### Situación 1
> El plano no es un objeto físico. El cubo es un objeto físico y la esfera no. En este caso, el plano y la esfera sólo tendrán collider, mientras que el cubo debe tener Rigidbody. 

Como el plano no es un objeto físico, no es afectado por la gravedad, al igual que la esfera. En el caso del cubo, este cae pero es sujetado por el plano al no tener la configuración de Trigger. Tanto el plano como la esfera tienen colisiones estáticas al no ser físicos, mientras que el cubo tiene una colisión dinámica. Según la documentación de Unity, ocurre la colisión y se notifica.

### Situación 2
> El plano no es un objeto físico. El cubo es un objeto físico y la esfera también. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody. 

En este caso, al añadirle físicas a la esfera, esta cae por acción de la gravedad, colisiona con el cubo y sale del plano, cayendo al vacío. El plano sería el único con colisión estática, mientras que la esfera y el cubo tienen colisión dinámica, ocurriendo los eventos de colisión entre todos y notificándose.

### Situación 3
> El plano no es un objeto físico. El cubo es un objeto físico y la esfera es cinemática. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody esta última cinemático. 

El plano se mantiene en su sitio al no ser físico. El cubo cae por la gravedad al ser dinámico y tener la gravedad activada. La esfera ahora no cae al ser de tipo cinemático, pues el movimiento se delega a los scripts que cambian su posición.
Según la tabla, la esfera y el plano no colisionarían en caso de moverse al tener colisiones cinemática y estática, respectivamente. Sin embargo, la esfera y el cubo sí colisionarían si se acercaran puesto que existe esta interacción entre cinemática y dinámica.

### Situación 3b
> El plano es un objeto físico. El cubo es un objeto físico y la esfera es física. En este caso, todos los objetos deben tener Rigidbody. 

Al ser todos los objetos físicos, caen al vacío sin tocarse por caer a la misma velocidad. Como tienen colisiones dinámicas, los eventos de colisión pueden ocurrir entre todos y chocarían en ese caso.

### Situación 4
> El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con 10 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody.

Tiene el mismo efecto que la situación 3b. La documentación de Unity indica lo siguiente: `A common mistake is to assume that heavy objects fall faster than light ones. This is not true as the speed is dependent on gravity and drag.`. Por tanto, el aumento de masa solo influiría en caso de colisión, pero al no tocarse entre ellos, no cambia la situación.

### Situación 5
> El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con 100 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody.

Mismo caso que en la situación 4. Al no haber contacto, el cambio de masa no influye en el resultado. Donde sí influye es en el choque que se pudiera realizar en otras situaciones. A más masa, más empuje se realiza sobre otros objetos al colisionar.

### Situación 5b
> El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con fricción. En este caso, todos los objetos deben tener Rigidbody.

TODO: pendiente a resolver la duda de la fricción

### Situación 6
> El plano es un objeto físico. El cubo es un objeto físico y la esfera no es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody.

TODO: pendiente a resolver las dudas con la gravedad

### Situación 6b
> El plano es un objeto físico. El cubo es un objeto físico y la esfera es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody.

TODO: pendiente a resolver las dudas con la gravedad

