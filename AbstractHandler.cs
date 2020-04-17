/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using Behavioral.ChainOfResponsibility;
using System;

namespace CsDesignPatterns_ChainOfResponsibility
{
    public abstract class AbstractHandler : IChain
    {
        protected AbstractHandler nextHandler;

        public void Execute(string request)
        {
            if (request == this.GetType().Name)
            {
                Console.WriteLine("{0} {1}", this.GetType().Name, "has handle an error");
                return;
            }

            if (nextHandler == null)
            {
                throw new Exception();
            }

            nextHandler.Execute(request);
        }

        /**
         * @param nextHandler
         * @return
         */
        public AbstractHandler SetNext(AbstractHandler nextHandler)
        {
            this.nextHandler = nextHandler;
            return nextHandler;
        }
    }
}
