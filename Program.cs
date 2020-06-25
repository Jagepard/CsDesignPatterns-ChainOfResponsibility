/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using CsDesignPatterns_ChainOfResponsibility;
using System;

namespace Behavioral.ChainOfResponsibility
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            AbstractHandler notice  = new NoticeHandler();
            AbstractHandler warning = new WarningHandler();
            AbstractHandler error   = new ErrorHandler();

            try
            {
                notice.SetNext(warning).SetNext(error);
                notice.Execute(notice.GetType().Name);
                notice.Execute(warning.GetType().Name);
                notice.Execute(error.GetType().Name);
            } catch (Exception e) {
                Console.WriteLine("Caught exception: {0} \n", e.GetHashCode());
            }
        }
    }
}
