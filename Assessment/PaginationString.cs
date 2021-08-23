using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment
{
    public class PaginationString : IPagination<string>
    {
        private readonly IEnumerable<string> data;
        private readonly int pageSize;
        private int currentPage;

        public PaginationString(string source, int pageSize, IElementsProvider<string> provider)
        {
            data = provider.ProcessData(source);
            currentPage = 1;
            this.pageSize = pageSize;
        }
        public void FirstPage()
        {
            currentPage = 1;
        }

        public void GoToPage(int page)
        {
            currentPage = page;
            Console.WriteLine("Go to page {0}", page);
        }

        public void LastPage()
        {
            currentPage = pageSize - 1;
            Console.WriteLine("Go to last page and is {0}", pageSize);
        }

        public void NextPage()
        {
            int nextPage = currentPage + 1;
            if(nextPage == pageSize + 1)
            {
                throw new InvalidOperationException();
            }
            else
            {
                currentPage = nextPage;
                Console.WriteLine("The next page is {0}", nextPage);
            }
        }

        public void PrevPage()
        {
            int prevPage = currentPage - 1;
            if(prevPage == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                currentPage = prevPage;
                Console.WriteLine("The previous page is {0}", prevPage);
            }
        }

        public IEnumerable<string> GetVisibleItems()
        {
            return data.Skip((currentPage - 1)*pageSize).Take(pageSize);
        }

        public int CurrentPage()
        {
            Console.WriteLine("Current page is {0}", currentPage);
            return currentPage;
        }

        public int Pages()
        {
            Console.WriteLine("Total pages are {0}", pageSize);
            return pageSize;
        }
    }
}