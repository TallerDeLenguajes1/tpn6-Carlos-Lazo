# tpn6-Carlos-Lazo


<h3><li>String es un tipo por valor o un tipo por referencia?</li></h3>
<p>String es un tipo por referencia</p>

<h3><li>Qué secuencias de escape tiene el tipo String?</li></h3>
<table>
<tr>
  <th>Secuencia de escape</th>
  <th>Nombre del personaje</th>
  <th>Codificación Unicode</th>
</tr>

<tr>
  <td>\'</td>
  <td>Una frase</td>
  <td>0x0027</td>
</tr>


<tr>
  <td>\"</td>
  <td>Cita doble</td>
  <td>0x0022</td>
</tr>


<tr>
  <td>\\</td>
  <td>barra invertida</td>
  <td>0x005C</td>
</tr>


<tr>
  <td>\0</td>
  <td>Nulo</td>
  <td>0x0000</td>
</tr>


<tr>
  <td>\una</td>
  <td>Alerta</td>
  <td>0x0007</td>
</tr>


<tr>
  <td>\si</td>
  <td>Retroceso</td>
  <td>0x0008</td>
</tr>

<tr>
  <td>\F</td>
  <td>alimentación de formulario</td>
  <td>0x000C</td>
</tr>

<tr>
  <td>\norte</td>
  <td>Nueva línea</td>
  <td>0x000A</td>
</tr>

<tr>
  <td>\r</td>
  <td>Retorno de carro</td>
  <td>0x000D</td>
</tr>

<tr>
  <td>\t</td>
  <td>Pestaña horizontal</td>
  <td>0x0009</td>
</tr>


<tr>
  <td>\v</td>
  <td>Pestaña vertical</td>
  <td>0x00B</td>
</tr>

<tr>
  <td>\u</td>
  <td>Secuencia de escape Unicode (UTF-16)</td>
  <td>\uHHHH(rango: 0000 - FFFF; ejemplo: \u00E7= "ç")</td>
</tr>

<tr>
  <td>\U</td>
  <td>Secuencia de escape Unicode (UTF-32)</td>
  <td>\U00HHHHHH(rango: 000000 - 10FFFF; ejemplo: \U0001F47D= "👽")</td>
</tr>

</table>

<h3>Qué sucede cuando utiliza el carácter <strong>@</strong> antes de una cadena de texto?</h3>

<p>El carácter @ actúa como prefijo de un elemento de código que el compilador debe interpretar como un identificador en lugar de como una palabra clave de C#</p>
<p>Para indicar que un literal de cadena se debe interpretar literalmente. El carácter @ de esta instancia define un literal de cadena textual. Las secuencias de escape sencillas (como "\\", que es una barra diagonal inversa), las secuencias de escape hexadecimales (como "\x0041", que es una A mayúscula) y las secuencias de escape Unicode (como "\u0041" que es una A mayúscula) se interpretan literalmente. Solo las secuencias de escape de comillas ("") no se interpretan literalmente, sino que generan comillas dobles. De igual modo, en el caso de una cadena interpolada literal, las secuencias de escape de llave ({{ y }}) no se interpretan literalmente, sino que generan caracteres de llave simple. En el siguiente ejemplo se definen dos rutas de archivo idénticas, una mediante un literal de cadena normal y otra mediante el uso de un literal de cadena textual.
Este es uno de los usos más comunes de los literales de cadena textual.</p>

<article border="1px"><strong>Ejemplo:</strong>
<p><span color="blue" text-color="red">string<span> filename1 = @"c:\documents\files\u0066.txt";</p>
<p>string filename2 = "c:\\documents\\files\\u0066.txt";</p>

<p>Console.WriteLine(filename1);</p>
<p>Console.WriteLine(filename2);</p>
<p>// El ejemplo muestra el siguiente resultado:</p>
<p>//     c:\documents\files\u0066.txt</p>
<p>//     c:\documents\files\u0066.txt</p>
</article>



