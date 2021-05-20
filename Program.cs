using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /** 
		Create-Shapes
		Lab 2 for Advanced Programming in .NET - COMP-10068
        Created by Norman Potts.
        Student ID: 000344657
        Start Date: Febuary, 13th 2017
        Due Date: Febuary, 17th 2017
        This C# program was created by Norman Potts with the student ID 000344657 for Lab2 of Advanced Programming in .NET. 
        This is my work and no one else's work has been used with out due acknowledgement.
    */
    /** Program Purpose
        The purpose of this program is to allow the user to create an instance of a shape that are one of the following types:
        Rectangle, Square, Box, Cube, Ellipse, Circle, Cylinder, Sphere, Triangle, and Tetrahedron
        The program will propmpt the user via a menu to create an instance of one of these shapes.
        The program will continue to propmt the user untill the user selects the exit option.
        The program will display a neat ordely table of all instantiated shapes, their dimensions,
        areas, and for three dimenional shapes their volumes.
    */
    /** Program's code structure requirements specified from instructions given.
        - Uses an abstract class called Shape which represents one single shape.
        - Creates an object hierarchy to include additional classes for Rectangle, Square, Box, Cube,     Ellipse, Circle, Cylinder,  Sphere,            Triangle, and Tetrahedron.
        - The main class should have an array to store up to 100 shapes of any kind.
        - Each of the obtained classes must implement in someway these methods:
            - SetData(). A method that prompts the user to enter each dimension for the current shape.
            - CalculateArea(). A method that calculates the area of the shape, or for a threedimensional shape, the surface area.
            - CalculateVolume(). A method that calculates the volume of three-dimensional shapes only.
            - overridden ToString(). A method that you can use to print each line of the table.
        - prompts the user from a menu to create one of the shapes
        - Continues to prompt until user selects exit.
        - Displays a table of all instantiated shapes with their dimensions, areas, and volumes for 3D shapes.
        - The main class should have Error checking for user input.
        - The main class should be highly modularized.
        - The shape class will use a unmodified code given in the instructions document. It will be saved and renamed as Shape.cs.
        - Each shape class should be coded in a different class file.
        - Must use an actual object hierarchy that does not simply involve having all classess descend from the base class.
    */

    /** Object Hierarchy
                                                                                     Shape
                      2D                                                                                         3D
        Triangle, rectangle,   ellipse                                                             tetrahedron,   cylinder,   box,    sphere
                  square,      circle                                                                                         cube      
   
    */

    /** Marking rubric. 
        Documentation: Comments, Naming Conventions /5
        Object hierarchy: proper Hierarchy Layout /1
        Rectangle, Square: Constructor, SetData, ToString, Area /2
        Ellipse, Circle: Constructor, SetData, ToString Area /2
        Box, Cube: Constructor, SetData, ToString, Area, Volume /3
        Cylinder, Sphere: Constructor, SetData, ToString Area, Volume /2
        Triangle, Tetrahedron: Constructor, SetData, ToString, Area, Volume /2
        Menu: All Options, Re-Prompts /1 Pretty sure its done.
        Output: Neat, Complete /2
    */
    /** Input, processing, Output chart for entire lab2 program.
        Input                                         |                              Processing                                                                |                                    output
        user enters shape  attributes from main menu. | Program determines shape's type from input then calculates their properties then creates output chart. | Shapes are displayed in a neat orderly table of all instantiated shapes, their dimensions, areas, and volume for 3d shapes.
    */

    /** Input menu
        Norman's Geometry Class:
        A - Rectangle   E - Ellipse     I - Triangle
        B - Square      F - Circle      J - Tetrahedron
        C - Box         G - Cylinder   
        D - Cube        H - Sphere

        0 - List all shapes and Exit...
        Enter your Choice:  (0 shapes entered so far)
    */

    /** Output 
        Norman's Geometry class:

        There are 5 objects: 
        Shape       Area        Volume       Details
        =========== ========== =========== ==================================
        Rectangle         2.00             1.00 l x 2.00 w
        Box              52.00       24.00 2.00 l x 3.00 w x 4.00h
        Circle           28.27             3.00 r
        Circle       248368.07             333.00 r
        Tetrahedron      27.71        7.54 4.00 l
            
    */
    /** Things i need to ask professor.
        - how should the object hierarchy look. Is mine correct?
        - what goes in the classes for each shape. What are the purpose of the classess? yes
        - Do we have to make an array similar to combic book array for all shapes or for one for each shape? 
        yes similar, something like Shapes myshapes = new array of shapes
        - is my comments and documentation good or can it be better?
    */


   public class Program
   {
      


        /** Pesodo of main.
            
            boolean userSelectsExitFlag = false;
            do
                do
                    
                    boolean ShapeTypeErrorcheck flag = false;
                    string shapeInput = "";
                    
            
                    Prompts input menu
                    shapeInput = waits for user to select shape type
                    ShapeTypeErrorcheck = CheckShapeTypeInput(shapeInput);
                    if ShapeTypeErrorcheck is false
                        display message which says input is  wrong and what is acceptable input.
            
                until ShapeTypeErrorCheckFlag is true.
                if (shapeInput != 0)
                    Char selectedShape = shapeIput;
                    Switch case (selectedShape)
                        case A
                            InputMangementShapeRectangle
                            break;
                        case B
                            InputMangementShapeSquare
                            break;
                        case C
                            InputMangementShapeBox
                            break;
                        case D
                            InputMangementShapeCube
                            break;
                        case E
                            InputMangementShapeEllipse
                            break;
                        case F
                            InputMangementShapeCircle
                            break;
                        case G
                            InputMangementShapeCylinder
                            break;
                        case H
                            InputMangementShapeSphere
                            break;
                        case I
                            InputMangementShapeTriangle
                            break;
                        case J
                            InputMangementShapeTetrahedron
                            break;
                        default :
                            Prompt InputMangement
                            break;
                    End SelectCase
                Else
                    userselectsexitFlag = true;                 
            until user selects exit.
            display Chart from created shapes.
        */
        static void Main(string[] args)
        {  
            Shape[] shapeArr = new Shape[100];

            int numOfShapesMade = 0;                                                //integer numOfShapesMade will keep count of the number of shapes that get created.
            Boolean userSelectsExitFlag = false;                                    //boolean userSelectExitFlag will control first loop which keep ends when user chooses zero.

            do {                                                                    //First loop. do while the user hasnt entered '0' to exit
                
                Boolean ShapeTypeErrorCheckflag = false;                            //boolean ShapeTypeErrorCheckflag will control second loop which ends when user enters a correct value. This allows for repromt of main menu when user enters inncorect value.
                char shapeInput = ' ';                                              //Character shapeInput will hold the returned character from promptsinputmenu method.

                do {
                    ShapeTypeErrorCheckflag = false;
                    

                    shapeInput = Promptsinputmenu(numOfShapesMade);                 //Call method promptsinputmenu(numOfShapesMade). Displays main menu and returns the user input. Integer numOfShapesMade is passed as a parameter to be displayed in the menu as the number of shapes that have been created.
                    shapeInput = Char.ToUpper(shapeInput);                          //Change Character too a upper case character.

                    ShapeTypeErrorCheckflag = CheckShapeTypeInput(shapeInput);      //Call method CheckShapeTypeInput(shapeInput). This checks the variable shapeinput and returnets false if shapeinput was not an allowed character. Returns true if it was a allowed character.
                    
                    //if shapeTypeErroCheckflag is false then display error message.
                    if (ShapeTypeErrorCheckflag == false)
                    {
                        //display message which says input is wrong and what is acceptable input.
                        Console.WriteLine("");
                        Console.WriteLine("The input was:" + shapeInput);
                        Console.WriteLine("Input was not accepted. Please enter a leter that is listed in the menu or 0 to show all objects that have been created.");
                    }

                    
                } while (ShapeTypeErrorCheckflag == false);                         //End of Second do while loop. if var ShapeTypeErrorCheckflag was set to true the loop will end. This means the input entered was an acceptable input for the menu.

                //If shapeInput is not '0' then it must be a letter of a menu choice of a shape. Else it is '0' and the user chose to display all the shapes.
                if (shapeInput != '0')                                              
                {
                    // This switch manages the choice of shape.
                    switch (shapeInput)
                    {
                        case 'A':                                                   // A was entered into input, meaning Rectangle was chosen
                            Rectangle rectangle = new Rectangle();
                            shapeArr[numOfShapesMade] = rectangle;
                            break;
                        case 'B':                                                   // B was entered into input, meaning Square was chosen
                            Square square = new Square();
                            //add square to shape array
                            shapeArr[numOfShapesMade] = square;
                            break;
                        case 'C':                                                   // C was entered into input, meaning Box was chosen
                            Box box = new Box();
                            shapeArr[numOfShapesMade] = box;
                            break;
                        case 'D':                                                   // D was entered into input, meaning Cube was chosen
                            Cube cube = new Cube();
                            shapeArr[numOfShapesMade] = cube;
                            break;
                        case 'E':                                                   // E was entered into input, meaning Ellipse was chosen
                            Ellipse ellipse = new Ellipse();
                            shapeArr[numOfShapesMade] = ellipse;
                            break;
                        case 'F':                                                   // F was entered into input, meaning Circle was chosen
                            Circle circle = new Circle();
                            shapeArr[numOfShapesMade] = circle;
                            break;
                        case 'G':                                                    // G was entered into input, meaning Cylinder was chosen
                            Cylinder cylinder = new Cylinder();
                            shapeArr[numOfShapesMade] = cylinder;
                            break;
                        case 'H':                                                   // H was entered into input, meaning Sphere was chosen
                            Sphere sphere = new Sphere();
                            shapeArr[numOfShapesMade] = sphere;
                            break;
                        case 'I':                                                   // I was entered into input, meaning Triangle was chosen
                            Triangle triangle = new Triangle();
                            shapeArr[numOfShapesMade] = triangle;
                            break;
                        case 'J':                                                   // J was entered into input, meaning Tetrahedron was chosen
                            Tetrahedron tretrahedron = new Tetrahedron();
                            shapeArr[numOfShapesMade] = tretrahedron;
                            break;
                        default:                                                    // Default shouldnt occur. Displays error message if it ever does, and switch flags to false so loop continues.
                            Console.WriteLine("Error: default switch option got selected. This shouldnt be possible");
                            userSelectsExitFlag = false;
                            ShapeTypeErrorCheckflag = false;
                            break;

                    }// End SelectCase

                    numOfShapesMade++;                                              // A shape has now been made. Increment numOfShapesMade by 1.
                }
                else //else for if shapeinput != 0
                {
                    userSelectsExitFlag = true;                                     // change userSelectsExitFlag to true because user entered 0 requesting shapes to be displayed.
                }// End if shapeinput != 0

            }while (userSelectsExitFlag == false);                                  // End of first loop. If user entered 0 then the userSelectsExitFlag would have been switched.

         
            displayChartFromCreatedShapes(shapeArr, numOfShapesMade);                                        //call method displayChartFromCreatedShapes. This displays all the choosen shapes.
        }

        /** Promptsinputmenu(int toltalnumShapes)
            The purpose of this method is to print the main menu. It lists all the choices of shape type.
            It records the input that the user enters, and returns it to main.
            the main menu should look like the following.

                Norman's Geometry Class:
                A - Rectangle   E - Ellipse     I - Triangle
                B - Square      F - Circle      J - Tetrahedron
                C - Box         G - Cylinder   
                D - Cube        H - Sphere

                0 - List all shapes and Exit...
                Enter your Choice:  (0 shapes entered so far)
        */
        public static char Promptsinputmenu(int toltalnumShapes)
        {
            string strInput;                                                            //String strInput will hold the raw string enter from the user.
            char Input;                                                                 //Character input will hold the input given from user.
            int chCount;                                                                //will hold the number of character in strInput

            do
            {
                //Print the main menu.
                Console.WriteLine("Norman's Geomety Class:");
                Console.WriteLine("A - Rectangle    E - Ellipse     I - Triangle");
                Console.WriteLine("B - Square       F - Circle      J - Tetrahedron");
                Console.WriteLine("C - Box          G - Cylinder");
                Console.WriteLine("D - Cube          H - Sphere");
                Console.WriteLine("");
                Console.WriteLine("0 - List all shapes and Exit...");
                Console.Write("Enter your Choice:"); Console.Write("     (" + toltalnumShapes + " shapes entered so far)");          //Print the number of shapes made
                Console.WriteLine("");
                strInput = Console.ReadLine();                                             //Record input from user as a character.

                //Test the size of strInput. It can only be 1 character long.
                chCount = strInput.Length;
                if (chCount != 1)
                {
                    Console.WriteLine("Your Input was too long. It can only be one character in length.");
                }
              //Continue displaying input message untill input is 1 charter long.
            } while (chCount != 1);

            Input = Convert.ToChar(strInput);                                           //convert strInput to a char.

            return Input;                                                               //Return the input the user entered.

        }
        

        /** CheckShapeTypeInput(Char ShapeInput)
            The purpose of this method is to see if ShapeInput is an acceptable character type.
            returns isnputokay true if it is an acceptable character type
            returns isinputokay false if it is not an acceptable character type.
        */
        public static Boolean CheckShapeTypeInput(Char ShapeInput)
        {
            Boolean isinputokay = false;
            char[] okayChars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'I','J', 'H', '0' };
            
            foreach( char ch in okayChars )
            {
                if (ShapeInput == ch)
                {
                    isinputokay = true;
                    break;
                }
            }

            return isinputokay;
        }

     
        /** The purpose of displayChartFromCreatedShapes():
            Is to Display a out put similar to to one below, with the correct data for each shape.
            
        Norman's Geometry class:

        There are 5 objects: 
        Shape       Area        Volume       Details
        =========== ========== =========== ==================================
        Rectangle        12.00             3.00 l x 4.00 W
        Box              66.00       36.00 3.00 l x 3.00 w x 4.00 h
        
        */
        public static void displayChartFromCreatedShapes(Shape[] shapeArr, int numOfShapesMade)
        {
            int shapeCount = 0;
            string message = "";
            

            Console.WriteLine("Norman's Gemoetry class:");
            Console.WriteLine("");
            Console.WriteLine("There are"+shapeCount+"objects:");
            Console.WriteLine("Shape       Area        Volume       Details");
            Console.WriteLine("=========== ========== =========== ==================================");
            /*
                for each shape that has been created 
                print it's type of shape, Area, Volume (if it has it), and details.
            */
            for (int i = 0; i < numOfShapesMade; i++)
            {
                if (shapeArr[i] != null)
                {
                    message = shapeArr[i].ToString();
                    Console.WriteLine(message);
                }
            }

            Console.WriteLine("=========== ========== =========== ==================================");
            string stop = Console.ReadLine();             //stops the program so i can see the output.
        }

    }
}
