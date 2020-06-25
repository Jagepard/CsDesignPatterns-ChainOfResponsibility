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
        private AbstractHandler _nextHandler;

        public void Execute(string request)
        {
            if (request == this.GetType().Name)
            {
                Console.WriteLine("{0} {1}", this.GetType().Name, "has handle an error");
                return;
            }

            if (_nextHandler == null)
            {
                throw new Exception();
            }

            _nextHandler.Execute(request);
        }

        public AbstractHandler SetNext(AbstractHandler nextHandler)
        {
            this._nextHandler = nextHandler;
            return nextHandler;
        }
    }
}
