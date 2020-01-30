/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace Behavioral.ChainOfResponsibility
{
    class App
    {
        static void Main(string[] args)
        {
            ChainInterface chain = new Chain();
            HandlerInterface notice = new NoticeHandler();
            HandlerInterface warning = new WarningHandler();
            HandlerInterface error = new ErrorHandler();

            try {
                chain.addToChain(notice);
                chain.addToChain(warning);
                chain.addToChain(error);
                chain.execute(notice.GetType().Name);
                chain.execute(warning.GetType().Name);
                chain.execute(error.GetType().Name);
            } catch (Exception e) {
                Console.WriteLine("Caught exception: %s \n", e.GetHashCode());
            }
        }
    }
}
