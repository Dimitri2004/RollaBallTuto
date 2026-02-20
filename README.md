## Mapa con obstaculos
Son object a los que se les asigno una colision, en caso del plano se le añadió aparte nav mesh surface para disponerle movimiento a la ia del enemigo.


## Player
Tiene un sistema de movimiento simple con el rigidbody para darle gravedad y mediante los vectors le asigne variables de posicion segun su deltaTime, cada movimiento es actualizado por frame para que sea seguido
Podemos permitirle saltar si asignamos el input y la fuerza que corresponda, en este caso seria en el ejez.



## Enemigo
El funcionamiento del enemigo es mediante un IANavigation un plugin de Unity que permite a un NavAgent moverse y permitir subir a ciertas superficies segun sus preferencias.
En caso de quere detectar el enemigo se deveria crear una variable transform que guarde su position y se le envie al texto del TextMesh para decir si colisiono si no si Esta lejos si esta cerca segun la distancia asignada.
 
## Camara
El movimiento de camara se realiza de la forma mas facil posible, con un transform segun la posicion del player, sihay un player asignado.


## Objetos recolectables
Se emplea las llamadas de OnEnteredTrigger o OnCollision para detectar cuando entro en contacto con cualquier objeto segun el tag que le asignemos, los perfabs son comodos para este tipo de objetos ya que sus caracteristicas se comparten con el resto.
Tambien se pueden especificar las condiciones de victoria o derrota si se cumple el marcador o si el enemigo murio.


<img width="1094" height="525" alt="imagen" src="https://github.com/user-attachments/assets/537313bd-c702-438c-805c-7922c5f8f75d" />
