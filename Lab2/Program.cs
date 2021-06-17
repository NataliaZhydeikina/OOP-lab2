using System;
using TextLib;
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text1 = new Text();
            text1.add("Lorem, ipsum dolor sit amet consectetur adipisicing elit. Praesentium dolores itaque, nihil earum officia et incidunt repellendus quasi, at beatae accusantium aliquid nobis possimus quod explicabo! Aperiam veritatis aut mollitia?");
            text1.add("Dolorem aperiam maxime aspernatur. Ducimus saepe esse fugit est adipisci facere id iusto, voluptate temporibus eos autem repudiandae distinctio vero, ullam cupiditate soluta necessitatibus libero illo possimus? Nam, eligendi accusantium.");
            text1.add("Labore quidem earum quaerat officia, corrupti nostrum? Rem culpa labore consectetur cum optio facere, commodi ratione doloremque eligendi perspiciatis exercitationem autem deserunt, quae aut natus, porro expedita laborum temporibus amet.");
            text1.add("Adipisci porro vero omnis aliquam recusandae, autem error eaque, ipsa fugiat et voluptas ratione pariatur. Voluptatum culpa sapiente, illo minus officia accusantium blanditiis possimus, quo dicta, quasi repellendus odio ipsam.");
            Console.WriteLine(text1);
            Text text2 = new Text("text");
            text2.add("text2");
            text2.add("text3");
            text2.add("text4");
            text2.add("text5");
            Console.WriteLine("text2: \n"+text2);
            text2.remove(0);
            Console.WriteLine("text2 without 0 item: \n" + text2);
            text2.remove("text4");
            Console.WriteLine("text2 without \"text4\": \n" + text2);
            text2.insert(0, "new text");
            Console.WriteLine("text2 change 0 item to \"new text\": \n" + text2);
            text2.clear();
            Console.WriteLine("clear text2: \n" + text2);
            Console.WriteLine("\ntext2 number of rows: " + text2.length());
            Console.WriteLine("\nis text1 contains \"Lorem\": " + text1.contains("Lorem"));
            Console.WriteLine("\nis text2 contains \"Lorem\": " + text2.contains("Lorem"));
        }
    }
}
