# Контрольная работа

## Задача

> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

## Описание алгоритма решения

1. Объявление массива с некоторыми значениями
2. Вызываем метод **getArrWereLenghLessThree** который возвращает массив, длина элементов которых меньше трех
   1. Внутри метода **getArrWereLenghLessThree** вызываем метод **getCountElemntMoreThree**
   2. Метод _getCountElemntMoreThree_ подсчитывает нам количество элементов массива длина которых больше 3-х. Это нам нужно для того, что бы описать сколько элементов будет в новом массиве.
3. Выводим получившийся массив на экран с помощью метода **showArr**
