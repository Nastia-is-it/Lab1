# Описание и алгоритм работы функций. #

## 1. Нужно вывести дробную часть числа ##
Нахожу остаток от дления на 1 (число целое), в результате чего целая часть откидывается и остаётся дробная
### <img width="424" height="159" alt="image" src="https://github.com/user-attachments/assets/f687086b-fc13-465d-9166-eea077db0351" />
Проверка работы: 
### <img width="405" height="59" alt="image" src="https://github.com/user-attachments/assets/42f787c7-aa8e-4bb5-9168-37c0acd36c44" />

## 2. Нужно преобразовать символ в число(цифру)
* Символ преобразую в строку
* Затем строку в число

### <img width="457" height="96" alt="image" src="https://github.com/user-attachments/assets/8e991333-2083-4d6a-95ef-f72a9a5d8cee" />

Проверка работы:
### <img width="588" height="62" alt="image" src="https://github.com/user-attachments/assets/b4eeef64-fbc5-45b9-a34f-967644dedb91" />

## Проверить число на двузначность: вернуть true, если число двузначное и false, если нет
* Введённое пользователем целое число преобразую в строку
* Делаю проверку: если длина этой строки равна 2, то возращаю true

Проверка работы:
### 1)
<img width="545" height="61" alt="image" src="https://github.com/user-attachments/assets/d6afaf7f-ecf0-4eaa-9faa-e350f9f1bcaf" />

### 2)
<img width="546" height="70" alt="image" src="https://github.com/user-attachments/assets/aa72ed10-9b9c-4ebc-b37a-e37f833a4979" />

## Проверить входит ли число в диапазон от a от b, при условии, что неизвестно какая граница больше, а какая меньше
* Проверяем условие a < b
* Если оно выполняется, то проверяем диапазон от a до b. Сравниваем искомое число с текущим, и когда найдётся возвращаю true
* Если нет, то проверяем диапазон от b до a, так же сравнивая искомое с текущим
* Если не нашлось, то возвращаю false

Проверка работы:
### 1)
<img width="304" height="126" alt="image" src="https://github.com/user-attachments/assets/845589f9-7624-4c6f-abb2-0cd9dbe3f283" />

### 2)
<img width="336" height="130" alt="image" src="https://github.com/user-attachments/assets/4034c44c-f8d8-43c7-9894-1c8dfcb87976" />

### 3)
<img width="310" height="130" alt="image" src="https://github.com/user-attachments/assets/1f39c8a2-8bed-4b1f-8e20-0d281514c98d" />

## Проверка на равенство трёх чисел. 
* Сравниваю числа между собой. Если a равно b И b равно c И a равно с, то возвращаю true
* Иначе false

### 1)
<img width="201" height="130" alt="image" src="https://github.com/user-attachments/assets/098412a8-5103-4c48-b4d7-2f2a0a4dfd81" />

### 2)
<img width="216" height="126" alt="image" src="https://github.com/user-attachments/assets/2adad78f-77ea-4ddc-81b2-c8966f3fc43f" />

### 3)
<img width="218" height="129" alt="image" src="https://github.com/user-attachments/assets/ee94500c-eaf6-47cb-a93d-d338c5fddbe0" />

## Найти модуль числа
* Если число отрицательное, то умножаю на -1 чтобы поменять знак и возвращаю
* Иначе просто возвращаю число
