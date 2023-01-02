using System;
using System.CodeDom;

namespace shopping
{
internal class Course
{
    private Produit produit;
    private int quantite;

    public Course(int _quantite, Produit _produit)
    {
        this.quantite = _quantite;
        this.produit = _produit;
    }

    public int GetQuantite()
        {
            return quantite;
        }

    public Produit GetProduit(Course course)
        {
            return course.produit;
        }

    public override string ToString()
    {
        return $"{this.quantite} {this.produit.AfficherProduit()}";
    }

    public void SetQuantity (Course course, int input)
        {
            course.quantite = input;
        }
}
}
