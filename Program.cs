using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Task1
{
    class Program
    {
        /*  ----------------------------Task1-----------------------------------
        class student
        {
            public string name;
            public float matricmarks;
            public float fscmarks;
            public float ecatmarks;
        }
        static void Main(string[] args)
        {
            student s = new student();
            Console.WriteLine(s.name);
            Console.WriteLine(s.matricmarks);
            Console.WriteLine(s.fscmarks);
            Console.WriteLine(s.ecatmarks);
            Console.ReadKey();

        }
        */

/*------------------------------Task2----------------------------------

      class student
        {
            public student()
            {
                Console.WriteLine("Default Constructor Called");
            }
            public string name;
            public float matricmarks;
            public float fscmarks;
            public float ecatmarks;
        }
        static void Main(string[] args)
        {
            student s = new student();
            Console.ReadKey();

        }
      */

/*-------------------------------Task3--------------------------------
class student
{
    public student()

{
    name = "Muhammad Zubair";
}
public string name;
public float matricmarks;
public float fscmarks;
public float ecatmarks;
}

static void Main(string[] args)
{
    student s = new student();

    Console.WriteLine(s.name);
    Console.ReadKey();
}
*/


/*-------------------------------Task4--------------------------------
class student
{
    public student()

    {
        name = "Muhammad Zubair";
        matricmarks = 1021F;
        fscmarks = 1014F;
        ecatmarks = 166F;
        aggregate = 81F;

    }
    public string name;
    public float matricmarks;
    public float fscmarks;
    public float ecatmarks;
    public float aggregate;
}

static void Main(string[] args)
{
    student s = new student();
    Console.WriteLine(s.name);
    Console.WriteLine(s.matricmarks);
    Console.WriteLine(s.fscmarks);
    Console.WriteLine(s.ecatmarks);
    Console.WriteLine(s.aggregate);
    Console.ReadKey();
}
*/

/*-------------------------------Task5--------------------------------
class student
{
public student()

{
name = "Muhammad Zubair";
matricmarks = 1021F;
fscmarks = 1014F;
ecatmarks = 166F;
aggregate = 81F;

}
public string name;
public float matricmarks;
public float fscmarks;
public float ecatmarks;
public float aggregate;
}

static void Main(string[] args)
{
student s = new student();
Console.WriteLine(s.name);
Console.WriteLine(s.matricmarks);
Console.WriteLine(s.fscmarks);
Console.WriteLine(s.ecatmarks);
Console.WriteLine(s.aggregate);
Console.WriteLine("----------------------------------------------------");
student s1 = new student();
Console.WriteLine(s1.name);
Console.WriteLine(s1.matricmarks);
Console.WriteLine(s1.fscmarks);
Console.WriteLine(s1.ecatmarks);
Console.WriteLine(s1.aggregate);
Console.WriteLine("----------------------------------------------------");
student s2 = new student();
Console.WriteLine(s2.name);
Console.WriteLine(s2.matricmarks);
Console.WriteLine(s2.fscmarks);
Console.WriteLine(s2.ecatmarks);
Console.WriteLine(s2.aggregate);
Console.ReadKey();
}
*/

/*   -------------------------------Task6--------------------------------
   class student
   {
       public student(string name)

       {
           this.name = name;
       }
       public string name;
       public float matricmarks;
       public float fscmarks;
       public float ecatmarks;
   }

   static void Main(string[] args)
   {
       student s = new student("Jack-Jill");
       student s1 = new student("Muhammad Zubair");

       Console.WriteLine(s.name);
       Console.WriteLine(s1.name);
       Console.ReadKey();
   }

*/
/*   -------------------------------Task7--------------------------------
class student
{
    public student(string name,float matricmarks,float fscmarks,float ecatmarks)

    {
        this.name = name;
        this.matricmarks = matricmarks;
        this.fscmarks = fscmarks;
        this.ecatmarks = ecatmarks;
    }
    public string name;
    public float matricmarks;
    public float fscmarks;
    public float ecatmarks;
}

static void Main(string[] args)
{
    student s = new student("Jack-Jill",1021F,1014F,166F);


    Console.WriteLine(s.name);
    Console.WriteLine(s.matricmarks);
    Console.WriteLine(s.fscmarks);
    Console.WriteLine(s.ecatmarks);
    Console.ReadKey();
}
*/
/*   -------------------------------Task8--------------------------------
class student
{
    public student(string name, float matricmarks, float fscmarks, float ecatmarks)

    {
        this.name = name;
        this.matricmarks = matricmarks;
        this.fscmarks = fscmarks;
        this.ecatmarks = ecatmarks;
    }
    public string name;
    public float matricmarks;
    public float fscmarks;
    public float ecatmarks;
}

static void Main(string[] args)
{
    student s = new student("Jack-Jill", 1043F, 1063F, 165F);
    student s1 = new student("Hamza", 1021F, 1034F, 169F);
    student s2 = new student("Saad", 1027F, 999F, 154F);


    Console.WriteLine(s.name);
    Console.WriteLine(s.matricmarks);
    Console.WriteLine(s.fscmarks);
    Console.WriteLine(s.ecatmarks);
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine(s1.name);
    Console.WriteLine(s1.matricmarks);
    Console.WriteLine(s1.fscmarks);
    Console.WriteLine(s1.ecatmarks);
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine(s2.name);
    Console.WriteLine(s2.matricmarks);
    Console.WriteLine(s2.fscmarks);
    Console.WriteLine(s2.ecatmarks);


    Console.ReadKey();
}
*/
/*   -------------------------------Task8--------------------------------
static void Main(string[] args)
{
    List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
    Console.WriteLine("FOR LOOP");
    for (int x = 0; x < num.Count; x++)
        Console.WriteLine(num[x]);
    Console.WriteLine("FOREACH LOOP");
    foreach (int x in num)
        Console.WriteLine(x);
    Console.ReadKey();
}
*/

/*------------------------------------------Clock Task-------------------------------------------------
        class clocktype
            {
            public clocktype()
            {

            }
            public clocktype(int hours)
            {
                this.hours = hours;
            }
            public clocktype(int hours,int minutes)
            {
                this.hours = hours;
                this.minutes = minutes;
            }
            public clocktype(int hours, int minutes,int seconds)

            {
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = seconds;
            }

            public int hours;
            public int minutes;
            public int seconds;

            public void increamentsecond()
            {
                seconds++;
            }

            public void increamentminutes()
            {
                minutes++;
            }
            public void increamenthours()
            {
                hours++;
            }
            public void printtime()
            {
                Console.WriteLine(hours + " " + minutes + " " + seconds);
            }

            public bool isequal(int h, int m, int s)
            {
                if (hours == h && minutes == m && seconds == s)
                    return true;
                else
                    return false;
            }
            public bool isequal(clocktype temp)
            {
                if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds;
                    return true;
                else
                    return false;
            }



        }




        static void Main(string[] args)
        {
            clocktype empty_time = new clocktype();
            Console.Write("Empty time : ");
            empty_time.printtime();

            clocktype hour_time = new clocktype(8);
            Console.Write("Hour time : ");
            hour_time.printtime();

            clocktype Minute_time = new clocktype(8,10);
            Console.Write("Minute time : ");
            Minute_time.printtime();

            clocktype Full_time = new clocktype(8, 10,10);
            Console.Write("Full time : ");
            Full_time.printtime();

            Full_time.increamentsecond();
            Console.Write("Full Time (INC seconds): ");
            Full_time.printtime();

            Full_time.increamentminutes();
            Console.Write("Full Time (INC minutes): ");
            Full_time.printtime();

            Full_time.increamenthours();
            Console.Write("Full Time (INC hours): ");
            Full_time.printtime();

            bool flag = Full_time.isequal(9, 11, 11);
            Console.WriteLine("Flag: " + flag);

            clocktype cmp = new clocktype(10, 12, 1);
            flag = Full_time.isequal(cmp);
            Console.WriteLine("Object Flag: " + flag);
            Console.ReadKey();

        }   */

/*------------------------------------------shop software-------------------------------------------------*/
class products
{
public products()
{
name = "coke";
catgory = 'G';
price = 70;
stock = 500;
minstock = 80;
}
public string name;
public char catgory;
public int price;
public int stock;
public int minstock;

}
static  List<products> it = new List<products>();
static void Main(string[] args)
{
products p1 = new products();
it.Add(p1);
mainmenu();

Console.ReadKey();


}
public static void mainmenu()
{
Console.Clear();
c:
string choice;
Console.WriteLine("a---ADD PRODUCT");
Console.WriteLine("b---VIEW ALL PRODUCT");
Console.WriteLine("c---FIND PRODUCT WITH HIGHEST UNIT PRICE");
Console.WriteLine("d---VIEW SALE TAX OF ALL PRODUCTS");
Console.WriteLine("e---PRODUCT TO BE ORDERED");
Console.Write("Enter your Choice: ");
choice = Console.ReadLine();
if (choice == "a")
add();
else if (choice == "b")
view();
else if (choice == "c")
highestP();
else if (choice == "d")
saletax();
else if (choice == "e")
threshold();
else
{
Console.WriteLine("Your Choice is Incorrect choice the correct--------------!!!!!!");
goto c;
}



}
public static void add()
{
Console.Clear();
char key;
products p = new products();
Console.Write("Enter name of product: ");
p.name = Console.ReadLine();
Console.Write("Enter catgory of product(G for GROCERY| F for FRUITES | o for other): ");
p.catgory = char.Parse(Console.ReadLine());
Console.Write("Enter price of product: ");
p.price = int.Parse(Console.ReadLine());
Console.Write("Enter stock of product: ");
p.stock = int.Parse(Console.ReadLine());
Console.Write("Enter Minimum stock of product: ");
p.minstock = int.Parse(Console.ReadLine());
it.Add(p);
Console.WriteLine("Press any key to exit: ");
key = char.Parse(Console.ReadLine());
mainmenu();

}
public static void view()
{


char key;
Console.Clear();
for (int x=0; x<it.Count; x++)
{
Console.WriteLine("Product: " + it[x].name );
Console.WriteLine("Category: " + it[x].catgory );
Console.WriteLine("Price: " + it[x].price );
Console.WriteLine("Stock: " + it[x].stock );
Console.WriteLine("Min stock: " + it[x].minstock);
Console.WriteLine("---------------------------------------------------------------------------");

}

Console.WriteLine("Press any key to exit: ");
key = char.Parse(Console.ReadLine());
mainmenu();
}
public static void highestP()
{
char key;
int lar = 0;
int index=0;
Console.Clear();
for (int x = 0; x < it.Count; x++)
{
if (it[x].price > lar)
{
    index = x;

}                  
}
Console.WriteLine("PRODUCT WITH HIGHEST UNIT PRICE: " + it[index].name);
Console.WriteLine("Category: " + it[index].catgory);
Console.WriteLine("Price: " + it[index].price);
Console.WriteLine("Press any key to exit: ");
key = char.Parse(Console.ReadLine());
mainmenu();

}
public static void saletax()
{
Console.Clear();
char key;
float tax;
for (int x = 0; x < it.Count; x++)
{
if(it[x].catgory=='G' || it[x].catgory == 'g')
{
    tax = (it[x].price * 10) / 100;
    Console.WriteLine("PRODUCT: " + it[x].price);
    Console.WriteLine("SALETAX: " + tax);
    Console.WriteLine("---------------------------------------------------------------------------");
}
else if (it[x].catgory == 'F' || it[x].catgory == 'f')
{
    tax =  (it[x].price * 5) / 100;
    Console.WriteLine("PRODUCT: " + it[x].price);
    Console.WriteLine("SALETAX: " + tax);
    Console.WriteLine("---------------------------------------------------------------------------");
}
else
{
    tax = (it[x].price * 15) / 100;
    Console.WriteLine("PRODUCT: " + it[x].price);
    Console.WriteLine("SALETAX: " + tax);
    Console.WriteLine("---------------------------------------------------------------------------");
}

}
Console.WriteLine("Press any key to exit: ");
key = char.Parse(Console.ReadLine());
mainmenu();
}
public static void threshold()
{
Console.Clear();
char key;
string p;
int value;
Console.Write("Enter the product: ");
p = Console.ReadLine();
Console.Write("Enter the threshold value of  product: ");
value = int.Parse(Console.ReadLine());
for (int x = 0; x < it.Count; x++)
{

    if (value<10)
    {
         Console.WriteLine("Product  Ordered ");
}
    else
    Console.WriteLine("Product Not Ordered ");
}
Console.WriteLine("Press any key to exit: ");
key = char.Parse(Console.ReadLine());
mainmenu();

}


}
}
