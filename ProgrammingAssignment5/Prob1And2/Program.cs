using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// add necessary components
using System.Xml;
using System.Xml.Linq;

namespace Prob1And2
{
    #region Assignment Specs
    /*
    PROB1
    Create a static method that
        creates an array of strings(the ordering of the strings should be random)
        create a LINQ statement that returns the strings that start with 'a' - 'f'
        output the result
        modify the array in such a way that the result will be different
        output the result again
        modify the array in such a way that the result will be different
        capture the result as a List<string> object and return it
    In Main, output the returned result

    PROB2
    - Create a static method that creates an XML document and saves it. 
      See pages 3 and 10 in Appendix B
    - Create a static method that creates an XML document from an array and saves it. 
      See page 12 in Appendix B
    - Create a static method that loads an XML document and prints it to the screen. 
      You can load the doc created in 2 above. See page  13 in Appendix B. Note that 
      all I am asking for is for you to load the document and print. You can ignore the 
      parsing part of the book's example code.

    At a minimum implement the examples from Appendix B. Extra points will be 
    awarded for coming up with a different example than what is in the book. 
    Additional bonus points will be awarded for something more complex than 
    the book's examples.
    */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region Prob1: LINQ
            Console.WriteLine("****** PROBLEM 1 ******\n");
            // in Main, output the returned result
            List<string> listResults = StringMethod();
            Console.WriteLine("Returned Results - using ToList<> Method");
            foreach(string s in listResults)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            #endregion


            #region Prob2: XML Using LINQ
            Console.WriteLine("****** PROBLEM 2 ******\n");
            // call methods for prob2
            Console.WriteLine("== CreateXMLDoc Method ==\n");
            CreateXMLDoc();
            Console.WriteLine("\n\n");
            Console.WriteLine("== MakeXElementFromArray Method ==\n");
            MakeXElementFromArray();
            Console.WriteLine("\n\n");
            Console.WriteLine("== LoadXMLDoc Method ==\n");
            LoadXMLDoc();
            Console.WriteLine("\n\n");
            #endregion
        }

        #region Prob1 Method
        static List<string> StringMethod()
        {
            // create an array of strings (order: random)
            string[] arrayOfStrings = {"apple", "bubble", "queen", "factory",
                                       "family", "tint", "chocolate"};
            // create a LINQ statement that returns the strings that start with
            // 'a' - 'f'
            var subset = from myString in arrayOfStrings
                         where myString.StartsWith("a") ||
                               myString.StartsWith("b") ||
                               myString.StartsWith("c") ||
                               myString.StartsWith("d") ||
                               myString.StartsWith("e") ||
                               myString.StartsWith("f")
                        orderby myString
                        select myString;
            // output the result
            Console.WriteLine("Query Results - using a foreach loop " +
                                "within StringMethod()");
            foreach(var s in subset)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            // modify the array in such a way that the result will be different
            arrayOfStrings[2] = "turtle";
            arrayOfStrings[6] = "elephant";
            // capture the result as a List<string> object and return it
            List<string> outputList = (from myString in arrayOfStrings
                                       where myString.StartsWith("a") ||
                                             myString.StartsWith("b") ||
                                             myString.StartsWith("c") ||
                                             myString.StartsWith("d") ||
                                             myString.StartsWith("e") ||
                                             myString.StartsWith("f")
                                       orderby myString
                                       select myString).ToList<string>();
            return outputList;
        }
        #endregion

        #region Prob2 Method
        // create a static method that creates an XML doc and saves it. 
        // see pages 3 and 10  in Appendix B
        static void CreateXMLDoc()
        {
            XDocument inventoryDoc =
                new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("Cars I have Owned"),
                    new XElement("Inventory",
                        new XElement("Car", new XAttribute("ID", "1"),
                        new XElement("Color", "Moonrock Silver"),
                        new XElement("Year", "2012"),
                        new XElement("Make", "Volkswagen"),
                        new XElement("Model", "Jetta"),
                        new XElement("PetName", "Jet")
                        ),
                        new XElement("Car", new XAttribute("ID", "2"),
                        new XElement("Color", "Pearl White"),
                        new XElement("Year", "2014"),
                        new XElement("Make", "Toyota"),
                        new XElement("Model", "Avalon"),
                        new XElement("PetName", "Whale")
                        )
                        )
                    );
            // save 
            inventoryDoc.Save("CarsIveOwned.xml");
            Console.WriteLine("Document Created and Saved Successfully.");
        }
        // create a static method that creates an XML doc from an array and 
        // saves it. See page 12 in Appendix B
        static void MakeXElementFromArray()
        {
            // create an anonymous array of anonymous types
            var people = new[]
            {
                new {FirstName = "Ava", Age = 24},
                new {FirstName = "Dean", Age = 26},
                new {FirstName = "Carol", Age = 34},
                new {FirstName = "Nate", Age = 34},
                new {FirstName = "Elsa", Age = 41},
                new {FirstName = "John", Age = 40}
            };

            // use a for loop to move data into the LINQ to XML object model
            XElement peopleDoc = new XElement("People",
                from c in people
                select new XElement("Person", new XAttribute("Age", c.Age),
                       new XElement("FirstName", c.FirstName)));
            Console.WriteLine(peopleDoc);
            peopleDoc.Save("PeopleList.xml");
        }
        // Create a static method that loads an XML doc and prints it to the
        // screen. You can load the doc created in 2 above. See page 13 in Appendix B. 
        // Note that all I am asking for you is to load the document and print. You
        // can ignore the parsing part of the book's example code. 
        static void LoadXMLDoc()
        {
            Console.WriteLine("Loading First Method's Doc\n");
            XDocument myDoc = XDocument.Load("CarsIveOwned.xml");
            Console.WriteLine(myDoc);
            Console.WriteLine("\n\n");
            Console.WriteLine("Loading Second Method's Doc");
            XDocument myDoc2 = XDocument.Load("PeopleList.xml");
            Console.WriteLine(myDoc2);
        }
        #endregion
    }
}
