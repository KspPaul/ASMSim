# ASMSim
This program simulates the basics behind assembly

[.exe Download](https://github.com/KspPaul/ASMSim/raw/master/ASMSim/bin/Debug/ASMSim.exe)
[a example Program which can calculate faculty of numbers](https://github.com/KspPaul/ASMSim/blob/master/Faculty.asm)
## Syntax and examples


The program can only use small written commands.Every command needs to be in a new line. 

### Storage
Currently there are 4 storage spaces. x and y can be used for comparing and for calculations. z and s can only be used for calculations.

### LDA
lda is used to load a number into the accumulator. You can directly load a number with a # or you can load it from a storage adresse
##### Examples
**_Loads directly a number:_** lda #1

 **_Loads from a adress:_** lda x

### STA
sta is used to store the accumulator in the storage
##### Examples
** _Stores the accumulator int the storage space x:_ ** sta x

### ADD
add is used to add a number to the accumulator. You can directly add number or add one from the storage
#### Examples
**_adds directly a number:_** add #4

 **_adds from a adress:_** add y

### SUB
sub is used to subtract a number from the accumulator. The Syntax is basicaly the same as the from add
#### Examples
**_subdratcs directly a number:_** sub #1

**_subdratcs x from the accumulator:_** sub x

### MUL
mul is used to mulitply a number with the accumulator. The Syntax is basicaly the same as the from add
#### Examples
**_multiplies directly a number with the accumulator:_** mul #4

**_multiplies x with the accumulator:_** mul x

### DIV
div is used to divide a number from the accumulator. The Syntax is basicaly the same as the from add
#### Examples
**_devides directly a number from the accumulator:_** div #3

**_devides y from the accumulator:_** div s

### JMP
jumps to a command in the code. it uses the line to know, where it has to jump.The line numbering starts with zero
#### Examples
**_jumps to linenumber 5: _** jmp 5

### JMZ
jumps if the accumulator is zero. The jumping works like jmp
#### Examples
**_jumps to linenumber 1 if accumulator is 0: _** jmz 1

### CMX AND CMY
jumps if x or y is the same as the accumulator
#### Examples
**_jumps if x is the same as the accumulator:_** cmx 1

**_jumps if y is the same as the accumulator:_** cmy 4
