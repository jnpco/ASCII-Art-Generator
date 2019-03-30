# ASCII-Generator

ASCII generator program than can convert an image into an ascii art, and that ascii art, into an image. 
Included are some image manipulation utility methods like grayscaling, contrast adjustment, and resizing.

Grayscaling and constrast adjustment methods use Lockbits instead of getPixels for a faster performance.

## Demo

*Generates ascii string from image file.*
<img src="ASCII-art/Demo/README/ImgToASCII.PNG" alt="ImgToASCII">

*Generates image from ascii string.*
<img src="ASCII-art/Demo/README/ASCIIToImg.PNG" alt="ASCIIToImg">

## Screenshots

<img src="ASCII-art/Demo/README/Original.png" height="300" alt="Original"> <img src="ASCII-art/Demo/README/Text.PNG" height="300" alt="asciiTextFile"> <img src="ASCII-art/Demo/README/img.PNG" height="300" alt="asciiStringToImg">

## Samples

[Samples folder](https://github.com/jnpco/ASCII-art/tree/master/ASCII-art/Demo/Samples)

----Planning to make a web api soon. Most probably using AWS Lambda (May convert api to cpp for faster execution speed).
