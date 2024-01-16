/*
1 задача.
Спроектируйте программу для построения генеалогического дерева.
Учтите, что у нас есть члены семьи у ого нет детей(де).
Есть члены семти у кого дети есть (взрослые)
Есть мужчины и женщины.

2 задача.
Доработать предыдущий класс реализовав методы вывода родителей, детей, братьев сестер (включая двоюродных), бабушек и дедушек.
Подумайте, как лучше реализовать данные методы.

3 задача.
Получив ссылку на самого старшего члена семьи вывести на экран его генеалогическое древо

Домашнее задание.
Доработайте приложение генеалогического дерева таким образом чтобы программа выводила на экран близких родственников (жену/мужа).
Продумайте способ более красивого вывода с использованием горизонтальных и вертикальных черточек.
 */

using static ConsoleApp1.Humans;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grand_father = new AdultFamilyMember() { Mother = null, Name = "Дед", Sex = Gender.Male };
            var father = new AdultFamilyMember() { Mother = null, Father = null, Name = "Папа", Sex = Gender.Male };
            var mother = new AdultFamilyMember() { Mother = null, Father = null, Name = "Мама", Sex = Gender.Female };
            var son = new Humans() { Mother = mother, Father = father, Name = "Сын", Sex = Gender.Male };
            mother.Children = new Humans[] { son };
            father.Children = new Humans[] { son };
            grand_father.Children = new Humans[] { father };
            grand_father.Print(2);
            Console.ReadLine();

        }

    }
}
