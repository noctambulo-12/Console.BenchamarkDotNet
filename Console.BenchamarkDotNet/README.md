
# Console.BenchamarkDotNet
La herramienta **BenchamarkDotNet** nos permite analizar el rendimiento de nuestra aplicación generando un proyecto aislado por cada método que marquemos con el decorador **Benchmark**.<p/>

De manera automatica se lanzarán ejecuciones en varias iteraciones, el cual permitirá ejecutar pruebas de rendimiento, extraer resultados y analizar los mismos, todo esto con pocas líneas de código.<p/>
**BenchamarkDotNet** genera los informes en diferentes formatos:
 * *.csv
 * *.html
 * *.md<p/>

<img src="https://github.com/noctambulo-12/Console.BenchamarkDotNet/raw/main/Screenshot/Archivo-Resulatdo.png"><p/>

Este proyecto vamos a medir el rendimiento en operaciones de concatenación de cadenas de texto ( `string` vs `StringBuilder` ):

<img src="https://github.com/noctambulo-12/Console.BenchamarkDotNet/raw/main/Screenshot/Resulatdo-Console.png">

#### Referencia:
1. https://benchmarkdotnet.org/
2. https://adamsitnik.com/the-new-Memory-Diagnoser/