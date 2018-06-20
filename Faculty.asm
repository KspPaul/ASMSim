lda #8
sta x
sta y
lda x
sub #1
sta x
jmz 10
mul y
sta y
jmp 2
hlt
