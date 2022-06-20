using System;
using System.Collections.Generic;

namespace Eval_2
{
    class Program
    {

        public abstract class Person
        {
            public string name;
        }
        public class Student : Person
        {
            
            public int studentID;
            public Student(string n, int id)
            {
                this.name = n;
                this.studentID = id;
            }

        }

        public class Teacher : Person
        {
            public string classTaught;

            public Teacher(string n, string c)
            {
                this.name = n;
                this.classTaught = c;
            }
        }
        static void Main(string[] args)
        {
            char input;

            List<Student> studentList = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();

            do
            {
                Console.WriteLine("\nMAIN MENU");
                Console.WriteLine("1. Students Information");
                Console.WriteLine("2. Teacher Information");
                Console.WriteLine("3. Exit Program");
                Console.Write("\nEnter Selection : ");

                input = Convert.ToChar(Console.ReadLine());

                switch (input)
                {
                    case '1':
                        do
                        {
                            Console.WriteLine("\nStudents Information");
                            Console.WriteLine("a. Create a new Entry");
                            Console.WriteLine("b. Find and display entry");
                            Console.WriteLine("c. Jump to main");
                            Console.Write("\nEnter Selection : ");

                            input = Convert.ToChar(Console.ReadLine());
                        
                            switch (input)
                            {
                                case 'a':
                                    Console.WriteLine("Enter new student name : ");
                                    string nameInput = Console.ReadLine();
                                    Console.WriteLine("Enter new student ID : ");
                                    int idInput = Convert.ToInt32(Console.ReadLine());
                                    studentList.Add(new Student(nameInput, idInput));
                                    break;
                                case 'b':
                                    Console.WriteLine("Find which student? Enter ID: ");
                                    int input2 = Convert.ToInt32(Console.ReadLine());
                                    bool found = false;
                                    foreach(Student s in studentList)
                                    {
                                        if (s.studentID == input2)
                                        {
                                            Console.WriteLine("Found Student Name: {0}, ID:{1}", s.name, s.studentID);
                                            found = true;
                                        }
                                    }
                                    if (!found)
                                    {
                                        Console.WriteLine("Student not in list!");
                                    }
                                    break;
                                case 'c':
                                    Console.WriteLine("Returning to Main menu");
                                    break;
                                default:
                                    Console.WriteLine("Invalid Entry! Try again.");
                                    break;
                            }
                        } while (input != 'c');
                        break;
                    case '2':
                        do
                        {
                            Console.WriteLine("\nTeacher Information");
                            Console.WriteLine("a. Create a new Entry");
                            Console.WriteLine("b. Find and display entry");
                            Console.WriteLine("c. Jump to main");
                            Console.Write("\nEnter Selection : ");

                            input = Convert.ToChar(Console.ReadLine());

                            switch (input)
                            {
                                case 'a':
                                    Console.WriteLine("Enter new Teacher name : ");
                                    string nameInput = Console.ReadLine();
                                    Console.WriteLine("Enter class taught : ");
                                    string classInput = Console.ReadLine();
                                    teacherList.Add(new Teacher(nameInput, classInput));
                                    break;
                                case 'b':
                                    Console.WriteLine("Find which teacher? Enter Name: ");
                                    string nameInput2 = Console.ReadLine();
                                    bool found = false;
                                    foreach (Teacher t in teacherList)
                                    {
                                        if (t.name.Contains(nameInput2))
                                        { 
                                            Console.WriteLine("Found Teacher Name: {0} Teaches : {1}", t.name, t.classTaught);
                                            found = true;
                                        }
                                    }
                                    if (!found)
                                    {
                                        Console.WriteLine("Teacher not in list!");
                                    }
                                    break;
                                case 'c':
                                    Console.WriteLine("Returning to Main menu");
                                    break;
                                default:
                                    Console.WriteLine("Invalid Entry! Try again.");
                                    break;
                            }
                        } while (input != 'c');
                        break;
                    case '3':
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid Entry! Try again.");
                        break;

                }
            } while (input != '3');

            
        }
    }
}
