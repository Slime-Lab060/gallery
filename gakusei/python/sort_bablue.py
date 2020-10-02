n = int(input('>'))
lst = [int(input()) for _ in range(n)]


def abc(lis):
    flg = True
    while flg:
        flg = False
        for i in range(len(lis) - 1):
            #print(i[i], '>', i[i + 1])
            if lis[i] > lis[i + 1]:
                lis[i], lis[i+1] = lis[i+1], lis[i]
                # print(lis)
                flg = True
    return lis


print(abc(lst))
