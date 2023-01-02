using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using shopping;


class Program
{

    static void Main(string[] args)
    {
        bool showMenu = true;
        ListCourse list = new ListCourse();

        while (showMenu)
        {
            showMenu = Menu(list);
        }
    }
    public static bool Menu(ListCourse list)
    {
        int cpt = 0;
        int input;
        Console.WriteLine("1--Ajouter un produit dans liste de courses 2--Supprimer un produit 3--Arrêter le programme 4-- Afficher la liste en cours 5-- Modifier un produit de la liste 6-- Obtenir le prix total de mes courses");
        input = Int32.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                if (cpt == 0)
                {
                    ProductAttributes(0, list);
                }
                else
                {
                    ProductAttributes(cpt++, list);
                }
                return true;
            case 2:
                RemoveProduct(list);
                return true;
            case 3:
                return false;
            case 4:
                list.DisplayListeCourse();
                return true;
            case 5:
                EditProduct(list);
                return true;
            case 6:
                list.GetCount();
                return true;
            default: return false;
        }
    }
    public static void ProductAttributes(int cpt, ListCourse list)
    {
        string name;
        int price;
        int qte;

        Console.WriteLine("Insérer le nom du produit à ajouter");
        name = Console.ReadLine();

        Console.WriteLine("Combien coute " + name + " ?");
        price = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Combien faut-il de " + name + " ?");
        qte = Int32.Parse(Console.ReadLine());

        Produit produit1 = new Produit(cpt, name, price);
        Course course1 = new Course(qte, produit1);

        list.AddProduct(course1);

    }

    public static void RemoveProduct(ListCourse list)
    {
        list.DisplayListeCourse();

        Console.WriteLine("Choisissez l'élément de la liste à supprimer");
        string input = Console.ReadLine();

        Course course = list.GetCourse(input);
        list.RemoveProduct(course);

        Console.Clear();

        list.DisplayListeCourse();
        Console.WriteLine("Le produit a bien été supprimé de la liste");
    }

    public static void EditProduct(ListCourse list)
    {
        list.DisplayListeCourse();

        Console.WriteLine("Choisissez l'élément de la liste à éditer");
        string input = Console.ReadLine();

        Course course = list.GetCourse(input);

        course.ToString();
        Console.WriteLine("Modifier nom (0), quantité (1), ou prix (2) ?");

        switch (Int32.Parse(Console.ReadLine()))
        {
            case 0:
                Console.WriteLine("Entrez le nouveau nom");
                course.GetProduit(course).SetName(Console.ReadLine());
                break;
            case 1:
                Console.WriteLine("Entrez la quantité du produit");
                course.SetQuantity(course, Int32.Parse(Console.ReadLine()));
                break;
            case 2:
                Console.WriteLine("Quel est le nouveau prix ?");
                course.GetProduit(course).SetPrice(Int32.Parse(Console.ReadLine()));
                break;
        }
    }
}

