# Итоговая контрольная работа

## **Задача:** Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры: 

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

---

## Решение задачи

1. Создать и заполнить исходный массив строк
2. Перебрать элементы исходного массива строк и посчитать какое количество элементов массива удовлетворяют условию (длина строки <= 3);
3. Создать новый массив строк, с количеством элементов подсчитанных в п.2;
4. Перебрать элементы исходного массива строк, копируя в новый массив элементы, удовлетворяющие условию (длина строки <= 3);
5. Вывести в консоль исходный и результирующий массивы.

