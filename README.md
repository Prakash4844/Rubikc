
<h1  align=center>RUBIKC</h1>

<P  align=center>

<img  src="Rubikc Splash Screen/RubikcV3-Black_Splash.png"  alt="Rubikc"><br><br>

Rubikc: The Rubik's Cube game. The Rubik's Cube is a 3-D combination puzzle originally invented in 1974 by Hungarian sculptor and professor of architecture Ernő Rubik<br><br>

Checkout here: [Coming Soon](#)

This uses the [Kociemba Algorithm](http://www.kociemba.org/)

if we look at clean the cube, we see 6*9 facelets.

![](http://www.kociemba.org/pics/cubeclean.gif)

## Cube string notation
The names of the facelet positions of the cube (letters stand for Up, Left, Front, Right, Back, and Down):
```
             |************|
             |*U1**U2**U3*|
             |************|
             |*U4**U5**U6*|
             |************|
             |*U7**U8**U9*|
             |************|
 ************|************|************|************
 *L1**L2**L3*|*F1**F2**F3*|*R1**R2**R3*|*B1**B2**B3*
 ************|************|************|************
 *L4**L5**L6*|*F4**F5**F6*|*R4**R5**R6*|*B4**B5**B6*
 ************|************|************|************
 *L7**L8**L9*|*F7**F8**F9*|*R7**R8**R9*|*B7**B8**B9*
 ************|************|************|************
             |************|
             |*D1**D2**D3*|
             |************|
             |*D4**D5**D6*|
             |************|
             |*D7**D8**D9*|
             |************|
```
A cube definition string "UBL..." means that in position U1 we have the U-color, in position U2 we have the
B-color, in position U3 we have the L color etc. according to the order `U1`, `U2`, `U3`, `U4`, `U5`, `U6`, `U7`, `U8`, `U9`, `R1`, `R2`,
`R3`, `R4`, `R5`, `R6`, `R7`, `R8`, `R9`, `F1`, `F2`, `F3`, `F4`, `F5`, `F6`, `F7`, `F8`, `F9`, `D1`, `D2`, `D3`, `D4`, `D5`, `D6`, `D7`, `D8`, `D9`, `L1`, `L2`, `L3`, `L4`,
`L5`, `L6`, `L7`, `L8`, `L9`, `B1`, `B2`, `B3`, `B4`, `B5`, `B6`, `B7`, `B8`, `B9`.

So, for example, a definition of a solved cube would be `UUUUUUUUURRRRRRRRRFFFFFFFFFDDDDDDDDDLLLLLLLLLBBBBBBBBB`
Solution string consists of space-separated parts, each of them represents a single move:
* A single letter by itself means to turn that face clockwise 90 degrees.
* A letter followed by an apostrophe means to turn that face counterclockwise 90 degrees.
* A letter with the number 2 after it means to turn that face 180 degrees.
e.g. **`R U R’ U R U2 R’ U`**



![Shuffled](https://user-images.githubusercontent.com/81550376/226800512-99b89e57-51f7-4a01-8829-9a9ff87f51a7.png)

![Solved](https://user-images.githubusercontent.com/81550376/226800517-f92b9a01-aa19-4ec5-83e8-94993ac1feed.png)


</P>

## Contributor ✨

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
     <td align="center"><a href="https://github.com/sagargoswami2001"><img src="https://avatars.githubusercontent.com/u/88379870?v=4" width="100px;" alt=""/><br /><sub><b>sagargoswami2001</b></sub></a><br />
    <a href="#question-sagargoswami2001" title="Answering Questions">💬</a> <a href="https://github.com/Prakash4844/Rubikc/commits?author=sagargoswami2001" title="Documentation">📖</a>
  </tr>
</table>
