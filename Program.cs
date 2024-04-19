using System;
using System.Linq;

public struct Student
{
    public string FullName; // Поле для хранения имени студента
    public int GroupNumber; // Поле для хранения номера группы студента
    public int[] Grades; // Поле для хранения оценок студента

    public double AverageGrade // Свойство для вычисления среднего балла студента
    {
        get { return Grades.Average(); } // Вычисление среднего балла на основе массива оценок
    }
}

public class Program
{
    public static void Main()
    {
        Student[] students = new Student[7]; // Создание массива студентов

        // Инициализация данных для каждого студента
        students[0] = new Student { FullName = "Кантеева А.Ю", GroupNumber = 22, Grades = new int[] { 5, 3, 5, 4, 4 } };
        students[1] = new Student { FullName = "Акбаров М.С.", GroupNumber = 35, Grades = new int[] { 5, 4, 2, 5, 3 } };
        students[2] = new Student { FullName = "Чекушин Н.С", GroupNumber = 46, Grades = new int[] { 5, 5, 5, 4, 4 } };
        students[3] = new Student { FullName = "Шорников И.Д.", GroupNumber = 22, Grades = new int[] { 5, 5, 5, 3, 5 } };
        students[4] = new Student { FullName = "Душин М.В.", GroupNumber = 17, Grades = new int[] { 5, 4, 3, 5, 3 } };
        students[5] = new Student { FullName = "Королева А.М.", GroupNumber = 46, Grades = new int[] { 4, 5, 3, 4, 3 } };
        students[6] = new Student { FullName = "Сергеева В.С.", GroupNumber = 35, Grades = new int[] { 5, 4, 4, 2, 5 } };

        // Сортировка массива студентов по возрастанию среднего балла
        Array.Sort(students, (x, y) => x.AverageGrade.CompareTo(y.AverageGrade));

        // Вывод информации о студентах после сортировки
        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.FullName}, Группа: {student.GroupNumber}, Средний балл: {student.AverageGrade}");
        }
    }
}