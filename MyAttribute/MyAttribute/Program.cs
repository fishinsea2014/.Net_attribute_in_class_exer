using MyAttribute.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute
{
    /// <summary>
    /// Attribute is a class, must inherite from class of Attribute
    /// What's the difference between attribute and annotations
/// 2 declare and use attribute, AttributeUsage
/// 3 get attribute in the run: extra information extra action
/// 4 Remark encapsulation, attribute validation
/// 5 job deployment
/// feature: bracket declaration
/// illusion: each feature brings its own function
/// in fact, after the feature is added, the compilation will generate IL inside the element, but we can't use it directly.
/// and there are records in metadata
/// features, by themselves, are useless
/// as the program runs, we can find features and apply them
/// any feature that works is due to active use
/// add additional information and behavior without breaking type encapsulation
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====In class exer of Attribute=========");

            try
            {
                {
                    Student student = new Student();
                    student.Id = 123;
                    student.Name = "MrSorry";
                    
                    student.Study();
                    string result = student.Answer("Eleven");
                    
                    //Validate a right QQ number of the student 
                    student.QQ = 123456;
                    Manager.Show(student);

                    //Validate a wrong QQ number of the student 
                    student.Name = "Jason";
                    student.QQ = 9999;
                    Manager.Show(student);


                }
                {
                    UserState userState = UserState.Normal;
                    UserState userState1 = UserState.Frozen;
                    Console.WriteLine(userState.GetRemark());
                    Console.WriteLine(userState1.GetRemark());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.Read();
        }
    }
}
