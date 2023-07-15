Контрольная работа по итогу 1го блока
Создать репозиторий на GitHub
Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
Написать программу, решающую поставленную задачу
Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] [“1234”, “1567”, “-2”, “computer science”] → [“-2”] [“Russia”, “Denmark”, “Kazan”] → []

Выполнение вышеуказанных заданий
Создан репозиторий на сайте GitHub
Нарисована блок-схема на сайте Programforyou

Решение задачи
Начало
|
|    Ввод элементов массива с клавиатуры и сохранение в переменную input
|    |
|    V
|    Разделение строки input на массив строк inputArray по запятым
|    |
|    V
|    Вызов функции FilterArray с параметром inputArray
|    |
|    V
|    Инициализация переменной count с нулевым значением
|    |
|    V
|    Для каждого элемента item в inputArray выполнить:
|    |   Если длина item меньше или равна 3:
|    |   |
|    |   V
|    |   Увеличение значения count на 1
|    |
|    V
|    Создание нового массива   размером count
|    |
|    V
|    Инициализация переменной index с нулевым значением
|    |
|    V
|    Для каждого элемента item в inputArray выполнить:
|    |   Если длина item меньше или равна 3:
|    |   |
|    |   V
|    |   Добавление item в newArray на позицию index
|    |   |
|    |   V
|    |   Увеличение значения index на 1
|    |
|    V
|    Вывод элементов newArray
|
Конец

Описание решении задачи:
Создаем два массивы с типом данных string. Второй массив будет служить для записи в него результата после вызова метода.
Создаем первый метод, который будет проходить по всем индексам первого массива и согласно заданному условию, будет проверять и выписывать индексы во второй массив, длина символов которых меньше или равно трем.
Результат первого метода хранится во втором массиве. Для того чтобы его вывести на экран нужно создать еще один метод, в котором также заданный цикл пройдется по всей длине второго массива.
После создания двух методов, нужно вызвать их на экран. Ответ получен.