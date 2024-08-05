namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            ///1. Find all products that are out of stock.
            var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);

            ///2. Find all products that are in stock and cost more than 3.00 per unit.
            result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0 && p.UnitPrice > 3);

            ///3. Returns digits whose name is shorter than their value.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortNamedDigits = Arr.Where((Name, Index) => Index > Name.Length);

            foreach (var item in shortNamedDigits)
            {
                Console.WriteLine(item);




            }
            #endregion

            #region LINQ - Ordering Operators

            ///1. Sort a list of products by name
            result = ListGenerator.ProductsList.OrderBy(P => P.ProductName);

            ///2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            string[] Arrr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = Arrr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            foreach (var item in sortedWords)
            {
                Console.WriteLine(item);
            }

            ///3. Sort a list of products by units in stock from highest to lowest.
            var sortHtoL = ListGenerator.ProductsList.OrderByDescending(p => p.UnitPrice);

            ///4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortByLenthThenAlapha = Arr3.OrderBy(p => p.Length).ThenBy(p => p);
            foreach (var item in sortByLenthThenAlapha)
            {
                Console.WriteLine(item);
            }

            ///5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWordsByLength = words.OrderBy(p => p.Length).ThenBy(p => p, StringComparer.OrdinalIgnoreCase);

            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }


            ///6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            var sortByCatThenPrice = ListGenerator.ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            ///7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            string[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortByLengthThenByCase = Arr4.OrderBy(p => p.Length).ThenByDescending(p => p, StringComparer.OrdinalIgnoreCase);
            foreach (var word in sortByLengthThenByCase)
            {
                Console.WriteLine(word);
            }


            ///8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] Arr5 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var digitsWithSecondLetterI = Arr.Where(p => p[1] == 'i').Reverse();

            foreach (var item in digitsWithSecondLetterI)
            {
                Console.WriteLine(item);
            }






            #endregion
        }
    }
}
