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
            try
            {
                AbstractHandler firstElementInTheChain = new NoticeHandler(); 
                firstElementInTheChain.SetNext(new WarningHandler()).SetNext(new ErrorHandler());
                firstElementInTheChain.Execute("NoticeHandler");
                firstElementInTheChain.Execute("WarningHandler");
                firstElementInTheChain.Execute("ErrorHandler");
            } catch (Exception e) {
                Console.WriteLine("Caught exception: {0} \n", e.GetHashCode());
            }
        }
    }
}
