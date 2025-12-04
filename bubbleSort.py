def bubble_sort(numberList):
    n = len(numberList)
    for i in range(n):
        for j in range(0, n - i - 1):
            if numberList[j] > numberList[j + 1]:
                numberList[j], numberList[j + 1] = numberList[j + 1], numberList[j]
    return numberList

def main():
    print("BubbleSort")
    arr = [1, 0, 7, 1, 6, 2, 9, 14, 2]
    print(bubble_sort(arr))

if __name__ == "__main__":
    main()