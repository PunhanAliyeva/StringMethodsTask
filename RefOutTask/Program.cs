namespace RefOutTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            //ReverseName("punhan");
            #endregion


            #region Task2
            //PrintInput("a::b::c::d::e");
            #endregion


            #region Task3
            //Test("a b,c.d/e");
            #endregion


            #region Task4
            //Fruit("Banana");
            #endregion


            #region Task5
            //Console.WriteLine(Polindrome("punNup"));
            #endregion

        }


        #region Task1
        //static void ReverseName(string name)
        //{
        //    var newName = name.Reverse();
        //    string str = "";
        //    foreach (var item in newName)
        //    {                                        
        //        str += item;
        //    }
        //    var newStr=str[0].ToString().ToUpper()+str.Substring(1, str.Length-1);
        //    Console.WriteLine(newStr);
        //}
        #endregion


        #region Task2
        //static void PrintInput(string text)
        //{
        //    var newText = text.Split("::");
        //    foreach (var item in newText)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion


        #region Task3
        //static void Test(string text)
        //{
        //    var letters=text.Split(' ', ',','.','/');
        //    foreach (var letter in letters)
        //    {
        //        Console.WriteLine(letter);
        //    }
        //}
        #endregion


        #region Task4
        //static void Fruit(string fruitName)
        //{
        //    var newFruit = fruitName.Split('a');
        //    string str = " ";
        //    foreach (var item in newFruit)
        //    {
        //        str += item;
        //    }
        //    Console.WriteLine(str);
        //}
        #endregion


        #region Task5
        //static bool Polindrome(string text)
        //{
        //    string newText=new string(text.Reverse().ToArray());
        //    return newText.Equals(text,StringComparison.OrdinalIgnoreCase);
        //}
        #endregion


    }
}