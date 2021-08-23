using System;
using System.Collections.Generic;

namespace Assessment
{
    public class StringProvider : IElementsProvider<string>
    {
        private readonly string separatorComma = ",";
        private readonly string separatorPipe = "|";
        private readonly string separatorSpace = " ";
        private string separatorOption = ",";

        public StringProvider(string option)
        {
            if (option.Equals('1')) this.separatorOption = separatorComma;
            else if (option.Equals('2')) this.separatorOption = separatorPipe;
            else if (option.Equals('3')) this.separatorOption = separatorSpace;
        }

        public IEnumerable<string> ProcessData(string source)
        {
            string[] sourceArr = source.Split(separatorOption);
            return sourceArr;
        }
    }
}