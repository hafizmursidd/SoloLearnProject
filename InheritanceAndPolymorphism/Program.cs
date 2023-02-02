using InheritanceAndPolymorphism.AbstractClass;
using InheritanceAndPolymorphism.Polymorphism;
using InheritanceAndPolymorphism.ProtectedMembers;

internal class Program
{
    private static void Main(string[] args)
    {

        //Main for protected class
       // RunProtected.Running();

        A newA = new A();

        //Main Polymorphism
        // RunPolymorphism.Running();

        //Main Run Abstract
        RunAbstract.Running();
       
    }
}