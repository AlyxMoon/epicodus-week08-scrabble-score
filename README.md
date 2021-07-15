# Epicodus Project | Week 08 | Scrabble Score

Make a console application that takes a word and returns the Scrabble score for that word. Make sure to start with your specs, and that you include a README for this project and create a Git repository for it. Here are the values of letters in Scrabble:

```
A, E, I, O, U, L, N, R, S, T       1
D, G                               2
B, C, M, P                         3
F, H, V, W, Y                      4
K                                  5
J, X                               8
Q, Z                               10
```

## Gameplan

need: a function that takes a single word as an argument, calculates the scrabble score of word based on the individual point values for each letter.

list/dictionary of letters and corresponding point values

create variable to represent word score
loop through each letter in inputted word
    get score of each letter
    add each letter score to the word score
return word score after loop is complete