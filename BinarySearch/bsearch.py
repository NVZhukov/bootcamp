from random import randint

x = randint(0, 100)

# метод последовательного перебора

count_perebor = 0
for i in range(0, 101):
    count_perebor += 1
    if i == x:
        print("Число найдено!")
        break
# print("Загаданное число - ", x," Для его поиска перебором потребовалось ",count_perebor," итераций",)

# метод рандомного угадывания

count_random = 1
y = randint(0, 100)
while x != y:
    count_random += 1
    y = randint(0, 100)

# print("Загаданное число - ",x,    " Для его поиска угадыванием потребовалось ", count_random," итераций",)

# метод бинарного поиска с помощью пользователя

# count_bin_hum = 1
# print("Я хочу сыграть с тобой в игру! Угадай число от 0 до 100")
# y = int(input("Введите число: "))
# while x != y:
#    if x < y:
#        print("меньше")
#    else:
#        print("больше")
#    y = int(input("Введите число: "))
#    count_bin_hum += 1
# print("Загаданное число - ", x," Для его поиска бинарным методом потребовалось ", count_bin_hum," итераций",)

# метод бинарного поиска без помощи пользователя
left = 0
right = 10000
x = randint(left, right)
count_bin = 1

mid = (left + right) // 2
while x != mid:
    if x < mid:
        right = mid - 1
    else:
        left = mid + 1
    count_bin += 1
    mid = (left + right) // 2
print(
    "Загаданное число - ",
    x,
    " Для его поиска бинарным методом потребовалось ",
    count_bin,
    " итераций",
)
