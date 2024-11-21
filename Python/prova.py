def  fibonacci(n):
    a,b = 0,1
    seq = []
    while a <= n:
        seq.append(a)
        a, b= b, a  + b
    return seq
