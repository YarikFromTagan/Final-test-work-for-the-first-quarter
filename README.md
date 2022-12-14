
# **Итоговая проверочная работа.**

## **Задача:**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### **Алгоритм решения задачи**

![Алгоритм](Algorithm.png)


### **Решение задачи:**
1. На основании заданной нами размерности массива **N**, методом **InputArray** создаем массив **inArray[ ]** путем последовательного ввода его элементов с клавиатуры с помощью организованного в методе цикла.
2. Для наглядности совершённых действий методом **PrintArray,** с помощью организованного в нём цикла, путем последовательного перебора элементов массива **inArray[ ]** выводим их в консоль на экран.
3. На следующем этапе программы массив **inArray[ ]** передаётся в метод **ConversionArray,** в котором первоначально с помощью организованного цикла происходит подсчёт количества его элементов состоящих из 3-х или менее символов (согласно условия задачи), а затем на основании этих сведений создаётся новый массив соответствующей размерности, в который с помощью ещё одного организованного цикла записываются необходимые нам элементы из массива **inArray[ ]**.
4. На последнем этапе работы программы с помощью метода **PrintArray,** выводим в консоль на экран элементы нового массива.