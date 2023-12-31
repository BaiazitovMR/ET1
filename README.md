## Задача:
Написать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.

## Задание:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой
основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе над этим небольшим проектом ]
(не должно быть так, что всё залито одним коммитом, как минимум
этапы 2, 3, 4 должны быть расположены в разных коммитах).

*Выполнение вышеуказанных заданий*
Создан репозиторий на сайте GitHub
Нарисована блок-схема на сайте Programforyou

## Решение задачи
![Алгоритм решения задачи](https://github.com/BaiazitovMR/ET1/blob/main/Algorithm.png)

## Описание решении задачи:
Создаем два массивы с типом данных string. Второй массив будет служить для записи в него результата после вызова метода.
Создаем первый метод, который будет проходить по всем индексам первого массива и согласно заданному условию, будет проверять и выписывать индексы во второй массив, длина символов которых меньше или равно трем.
Результат первого метода хранится во втором массиве. Для того чтобы его вывести на экран нужно создать еще один метод, в котором также заданный цикл пройдется по всей длине второго массива.
После создания двух методов, нужно вызвать их на экран. Ответ получен.