# ASMSim
This program simulates the basics behind assembly

[.exe Download](https://github.com/KspPaul/ASMSim/raw/master/ASMSim/bin/Debug/ASMSim.exe)
## Syntax and examples

### LDA
lda is used to load a number into the accumulator. You can directly load a number with a # or you can load it from a storage adresse
###### Examples
** Loads directly a number: ** lda #1
** Loads from a adress: ** lda x

### STA
sta is used to store the accumulator in the storage
###### Examples
** Stores the accumulator int the storage space x: ** sta x

### ADD
add is used to add a number to the accumulator. You can directly add number or add one from the storage
##### Examples
** adds directly a number: ** add #4
** adds from a adress: ** add y

### SUB
sub is used to subtract a number. The Syntax is basicaly the same as the from add
##### Examples
** subdratcs directly a number: ** sub #1
** subdratcs from a adress: ** sub x
