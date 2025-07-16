namespace SESSIONCS05
{

    // 0->255
    enum season
    {
        spring,
        winter,
        summer,
        Autumn
    }

    enum weekday
    {
        saturday,
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday
    }

    enum gender
    {
        M = 1,
        F =2,
        Male =1,
        female =2
    }


    [Flags]
    enum permissions
    {
        Read =8,
        write = 4,
        Execute=2,
        delete = 1,
    }


    internal class Program
    {
        //static void dosomecode()
        //{
        //    int x, y, z;
        //    x = int.Parse(Console.ReadLine());
        //    y = int.Parse(Console.ReadLine());

        //    z = x / y;

        //    int[] arr = { 1, 2, 3 };

        //    arr[99] = 10;

        //}


        //static void dosomecode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        x = int.Parse(Console.ReadLine());
        //        y = int.Parse(Console.ReadLine());

        //        z = x / y;

        //        int[] arr = { 1, 2, 3 };

        //        arr[99] = 10;
        //    }
        //    catch(FormatException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    catch(DivideByZeroException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    catch(IndexOutOfRangeException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }finally
        //    {
        //        Console.WriteLine("finally");

        //        //  disconnect | dispose unmanaged resource
        //    }

        //}


        //static void dosomeprotectivecode()
        //{
        //    int x, y, z;

        //    bool Flag;
        //    do
        //    {
        //        Console.Write("enter first number");
        //        int.TryParse(Console.ReadLine(), out x);

        //    } while (Flag == false);

        //    do
        //    {
        //        Console.Write("enter first number");
        //        int.TryParse(Console.ReadLine(), out y);

        //    } while (Flag == false ||y==0);

        //    z = x / y;

        //    int[] arr = { 1, 2, 3 };
        //    if(99<arr?.Length)
        //    {
        //        arr[99] = 10;
        //    }

        //}
        static void Main(string[] args)
        {

            #region boxing and unboxing 
            //boxing and unboxing 

            //boxing : casting from valuetype to referencetype
            //unboxing : casting from referencetype to valuetype

            //object O1;
            ////O1 =>can refer to instant of "object" or any instant of any type 

            ////O1 = 1;
            ////O1 = "ahmed";

            //O1 = 3;              //cast from valuetype [int] to referencetype [object]      => boxing 
            //O1 = 1.5;            //cast from valuetype [double] to referencetype [object]   => boxing 
            //O1 = 'A';            //cast from valuetype [char] to referencetype [object]     => boxing 
            //O1 = true;           //cast from valuetype [bool] to referencetype [object]     => boxing  
            //O1 = new DateTime(); //cast from valuetype [datetime] to referencetype [object] => boxing 

            //int x = 5;

            //object O1 = /*(object)*/x;


            //implicit casting 
            //safe casting 
            //boxing 
            //parent = child => child is parent 
            //animal = dog => dog is animal

            //object O1 = 3;

            //int x =(int) O1;

            //explicit casting 
            //unsafe casting [may throw exception]
            //unboxing 
            //dog = (dog) animal => animal is dog
            //child = parent => parent is child  
            #endregion

            #region nullable valuetype
            //nullable types 

            //value type 
            //reference type 

            //int x = 6;

            //x = null; //not valid 

            //nullable value type => value type allow null as valid value

            //Nullable<int> : allow int value or null as valid value 
            //int? age = 20;

            //age = null;

            //nullable<double> : allow double value or null as valid value
            //double? salary = 4000.5;

            //salary = null;



            //int x = 5;

            //y : nullable<int>
            //y : allow int value or null

            //int? y = x;

            //implicit casting 
            //safe casting 

            //Console.WriteLine(y);


            //int? x = 5;

            //x = null;
            // y : int 
            // y : allow int value only

            //int y ;

            // explicit casting 
            // may throw exception 


            //defencive code

            //if (x != null)
            //    y = (int)x;
            //else
            //    y = 0;

            /*====================*/

            //if (x is not null)
            //    y = (int)x;
            //else
            //    y = 0;


            /*====================*/

            //if (x.HasValue)
            //    y = x.Value;
            //else
            //    y = 0;

            /*====================*/

            //y = x.HasValue ? x.Value : 0;

            /*====================*/

            //y = x is not null ? x.Value : 0;

            /*====================*/

            //null coalascing operator ??

            /*y = x ??  0;*/ // syntax sugar : y = x is not null ? x.Value : 0;


            //Console.WriteLine(y); 
            #endregion


            #region      //nullable reference type [c# 10.0 .net 6.0]

            //nullable reference type [c# 10.0 .net 6.0]

            //string message01 = null;  //required

            //string? message02 = null; //nullable

            //Console.WriteLine(message01.Length);
            //Console.WriteLine(message02); 
            #endregion


            #region  null propagation operator 

            //null propagation operator ? 

            //double x = default; //0
            //bool c = default; 

            //Console.WriteLine(c);


            //int[] arr = default; //null
            //int[] arr = { 1, 2, 3, 4, 5 }; //null


            //best practice 
            //if (arr is not null )
            //{
            //    for (int i = 0; (arr is not null) && i < arr.Length; i++)
            //        Console.WriteLine(arr[i]);
            //}


            //for (int i = 0; (arr is not null) && i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);


            //for (int i = 0; i < arr?.Length; i++)
            //    Console.WriteLine(arr[i]);



            //E?.department?.deptname 

            //int len = arr is not null ? Arr.length :0;

            //int? len = Arr?.length is not null ? Arr.length : 0;

            //int len = Arr?.length ?? 0;


            //Console.WriteLine(len); 
            #endregion


            #region exception handling and protective code 

            //exception handling and protective code 

            //dosomecode();

            //Console.WriteLine("hello after exception");

            //Exception 
            //1. systemexception
            //  1.1.formatexeption
            //  1.2.indexoutofrangeexeption
            //  1.3.nullreferenceexeption
            //  1.4.arithmeticexeption
            //      1.4.1.overflowexception
            //      1.4.2.dividebyzeroexception
            //2. applicationexeption 
            #endregion


            #region Enum
            //Enum : value type 
            //STACK


            //int number = 10;

            //season S01 = season.Autumn;

            //S01 = season.summer;

            //Console.WriteLine(S01);

            //STACk

            //CLR represent Enum as integer value in memory 

            //gender G01 =(gender) 10;

            //Console.WriteLine(G01);

            //gender G01 =(gender) Enum.Parse( typeof (gender),Console.ReadLine(),true);

            //Enum.TryParse(typeof(gender), Console.ReadLine(), true,out object O1);

            //G01 = (gender)O1;

            //Console.WriteLine(G01);


            //permissions per01 = permissions.Read;
            //per01 ^= permissions.delete; // Toggle 

            //per01 |= permissions.delete; //add permissions 

            //Console.WriteLine(per01); //delete,read

            //per01 ^= permissions.delete; // Toggle 

            //Console.WriteLine(per01); //read
            //Console.WriteLine(per01); //delete,read

            //per01 &= ~(permissions.delete);//~ not bitwise 

            ////& -> check permissions 

            //if( (per01&permissions .delete) == permissions.delete)

            //{
            //    Console.WriteLine("Exists");
            //}
            //else
            //{
            //    Console.WriteLine("not exists");
            //} 
            #endregion



        }
    }
}
