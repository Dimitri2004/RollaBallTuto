## Mapa con obstaculos
Son object a los que se les asigno una colision, en caso del plano se le añadió aparte nav mesh surface


## Player
Tiene un sistema de movimiento simple con el rigidbody para darle gravedad y mediante los vectors le asigne variables de posicion segun su deltaTime, cada movimiento es actualizado por frame para que sea seguido



## Enemigo
El funcionamiento del enemigo es mediante un IANavigation un plugin de Unity que permite a un NavAgent moverse y permitir subir a ciertas superficies segun sus preferencias
 
## Camara
El movimiento de camara se realiza de la forma mas facil posible, con un transform segun la posicion del player, si lo hay.


## Objetos recolectables
Se emplea las llamadas de OnEnteredTrigger o OnCollision para detectar cuando entro en contacto con cualquier objeto segun el tag que le asignemos, los perfabs son comodos para este tipo de objetos ya que sus caracteristicas se comparten con el resto.


<img width="1094" height="525" alt="imagen" src="https://github.com/user-attachments/assets/537313bd-c702-438c-805c-7922c5f8f75d" />
