# THREADING
[Original Link](http://www.albahari.com/threading/)
[MD markup](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet)

## Part 1: Comenzando

### Cómo funciona el Threading
#### Ejemplos A01 hasta A05

* Concepts: time-slicing & genuine concurrency.

En windows el `time-slice` es del orden de decenas de milisegundos mucho mayor que la sobrecarga de tiempo que usa la CPU para el `switching context` que es del orden de pocos microsegundos.

En un ordenador con multi-procesador el multithreading es implementado con ambos conceptos, time-slicing y verdadera concurrencia.

### Threads versus Procesos
* Los procesos están completamente aislados unos de otros
* Los hilos (Threads) comparten la memoria HEAP
* Ejemplos de memoria HEAP and STACK

### Usos del Threading
* Pantalla 'responsive'
* Tareas que bloquean la CPU
* Parallel programming
* Ejecución especulativa
* Requests procesadas simultaneamente

### Cuidado
* Concepto: Thread Safe

Usando ASP.NET o WCF, tal vez estás usando multithreading sindarte cuenta, hasta que accedes a datos compartidos, tal vez campos estáticos sin hacer el lock apropiado.

* Multithreading puede aumentar mucho la complejidad, el debug y reproducir errores.
* Threading también aumenta el costo de `scheduling` and switching de los hilos, sobretodo cuando hay más threads activos que los cores del CPU. También para crearlos y matarlos

### Creando y Lanzando Threads
#### Ejemplos A06 hasta XXXXXXXXXXXXXXXXXXXXXXXXXXX

* Lock & Join
* Delegates
* Sharing data
** Instance
** Statics
** Variables
** Lambdas
* Naming
* Foreground & Background
* Priority
* Exception Handlng






