# deikstra-sharp
## About
Algorithm Deikstra on C#. Finding the shortest path in a graph.

## How to use
1. Clone this repo:

```sh
$ git clone https://github.com/the-shichko/deikstra-sharp
```

2. Declare object Deikstra
```sh
var deikstra = new Deikstra();
```
3. Declare adjacency matrix in object
```sh
deikstra.Matrix = new decimal[4, 4]
            {
                { 0, 2, 5, 3 },
                { 3, 0, 5, 2 },
                { 3, 0, 0, 4 },
                { 3, 0, 0, 0 },
            };
```
4. Start algorithm

> Parameter - the number of the vertex from which to find the paths ***[0, size of matrix - 1]***
```sh
var result = deikstra.Start(0);
```

5. Result of method is array of weights
