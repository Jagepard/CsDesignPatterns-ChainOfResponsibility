/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace Behavioral.ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IChain chain = new Chain();
            IHandler notice = new NoticeHandler();
            IHandler warning = new WarningHandler();
            IHandler error = new ErrorHandler();

            try
            {
                chain.AddToChain(notice);
                chain.AddToChain(warning);
                chain.AddToChain(error);
                chain.Execute(notice.GetType().Name);
                chain.Execute(warning.GetType().Name);
                chain.Execute(error.GetType().Name);
            } catch (Exception e) {
                Console.WriteLine("Caught exception: {0} \n", e.GetHashCode());
            }
        }
    }
}
