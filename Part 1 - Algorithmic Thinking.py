def prime(x):
    if x <= 1:
        return False
    for i in range(2,x):
        if (x%i) == 0:
            return False
    return True

n_max = 0
a_max = 0
b_max = 0

for a in range(-999,1000):
    for b in range(-1000,1001):
        isPrime = True
        n = 0
        while isPrime == True:
            number = (n*n) + (a*n) + b
            isPrime = prime(number)
            if isPrime == False:
                if n_max < n:
                    n_max = n
                    a_max = a
                    b_max = b
            n += 1

product = a_max * b_max

print("Equation: (n*n)-(" + str(abs(a_max)) + "*n)+" + str(b_max))
print("Product:" + str(product))