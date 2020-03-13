
namespace ClassTask_2
{
    class Parser
    {
        public string ParsingString { get; set; }

        public Parser(string ourString)
        {
            ParsingString = ourString;
        }

        private string[] AddToArray(string tempstring, string[] strinarray)
        {

            string[] newStrinArray = new string[strinarray.Length + 1];

            for (int i = 0; i < strinarray.Length; i++)
            {
                newStrinArray[i] = strinarray[i];
            }
            
            newStrinArray[strinarray.Length] = tempstring;

            return newStrinArray;
        }

        public string[] StringParsing()
        {
            char[] charString = ParsingString.ToLower().ToCharArray();

            string[] parsedWOrds = new string[1];

            string tempstring = "";

            if (ParsingString != "")
            {
                for (int i = 0; i < charString.Length; i++)
                {
                    if (charString[i] >= '\u0061' && charString[i] <= '\u007a')
                    {
                        tempstring += charString[i];
                    }
                    else if (tempstring != "")
                    {
                        parsedWOrds = AddToArray(tempstring, parsedWOrds);
                        tempstring = "";
                    }
                }
            }

            return parsedWOrds;
        }
    }
}
