# ASMSim
This program simulates the basics behind assembly

[.exe Download](https://github.com/KspPaul/ASMSim/raw/master/ASMSim/bin/Debug/ASMSim.exe)
## Syntax and examples

### LDA
lda is used to load a number into the accumulator. You can directly load a number with a # or you can load it from a storage adresse
###### Examples
** _Loads directly a number:_ ** lda #1
** _Loads from a adress:_ ** lda x

### STA
sta is used to store the accumulator in the storage
###### Examples
** _Stores the accumulator int the storage space x:_ ** sta x

### ADD
add is used to add a number to the accumulator. You can directly add number or add one from the storage
##### Examples
** _adds directly a number:_ ** add #4
** _adds from a adress:_ ** add y

### SUB
sub is used to subtract a number. The Syntax is basicaly the same as the from add
##### Examples
** _subdratcs directly a number:_ ** sub #1
** _subdratcs from a adress:_** sub x
