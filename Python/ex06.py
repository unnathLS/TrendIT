A = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
B = [[7, 8, 9], [4, 5, 6], [1, 2, 3]]
C = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]

for i in range(3):
    for j in range(3):
        C[i][j] = A[i][j] + B[i][j]
    
print(C)

D = [[1, 2, 3,],
     [4, 5, 6,],
     [0, 0, 0]]

for i in range(2):
    for j in range(3):
        D[2][j] = D[2][j] + D[i][j]

print(D)