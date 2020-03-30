# N Queens problem - Local Search Algorithms

## Main Classes:
- **NQueensProblem**

manages the `chessboard` and `algorithm`.
- **Parameters**

stores the parameters selected by the user.

- **Chessboard**

stores `size of chessboard`, `actual state of the chessboard` (two dimensional array), `information if state is solved`, `steps taken` in algorithm, `heuristic result` of actual state and parameters.

- **Algorithm**

has the necessary functions that will be used by inheriting classes, for example: `heuristic` function.

## Algorithms:
### 1. Hill Climbing Algorithm - Hill Climbing with random restart

Solves problem with defualt parameters for: `4x4`, `5x5`, `6x6`, `7x7`, `8x8`, `9x9`

Parameters: 

`MaximumNumberOfSteps` (maximum number of steps) - default: `50`

**How does this work?**

1. Move queen vertically (from top to bottom) in every column (from left to right):
  queen stays on place where heuristic result is the lowest.
2. If heuristic result after move is 0: return solved board
3. If board is blocked (we didn't move any queen in 1st step) new board will be generated.
4. Repeat steps 1, 2 and 3 until maximum number of steps is reached.

### 2. Simulated Annealing Algorithm

Solves problem with defualt parameters for: `4x4`, `5x5`, `6x6`

Parameters: 

`StartingTemperature` (starting temperature) - default: `10 000`

`CoolingFactor` (cooling factor) - default: `1`

**How does this work?**

1. Randomly move 1 queen
2. If heuristic result of state after move is better: save it
3. If heuristic result of state after move is worse or equal:
  
  a) Calculate `probability of accetance`: min(1,e^(h/T);
  
  `h` = `current heuristic result` - `new heuristic result`
  
  `T` = `Temperature`
  
  b) Generate random value from 0 to 1
  
  c) If generated random value is smaller or equal `probability of accetance`: new state is saved. Otherwise: move isn't saved.
  
4. Reduce `Temperature` by `CoolingFactor`.
5. If board after move is solved (heuristic result == 0) return solved board
6. Repeat steps 1-6 until `Temperature` is bigger than 0.

### 3. Local Beam Search Algorithm

Solves problem with defualt parameters for: `4x4`, `5x5`, `6x6`, `7x7`, `8x8`, `9x9`, `10x10`, `11x11`, `12x12`

Parameters: 

`MaximumNumberOfSteps` (maximum number of steps) - default: `50`
`NumberOfStates` (number of states) - default: `20`

**How does this work?**

1. Generate X random states and save them into `states` list
2. Find best state in list (the lowest heuristic result)
3. If best result == 0: return best state
4. Move queens in every column on theirs best local position in every state
5. Blocked states (states that didn't get changed after step 4) are changed into random states
6. Repeat steps 2-6 until maximum number of steps is reached

### 4. Genetic Algorithm