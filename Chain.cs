/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;
using System.Collections.Generic;

namespace Behavioral.ChainOfResponsibility
{
    public class Chain : IChain
    {
        private readonly IDictionary<string, IHandler> chain = new Dictionary<string, IHandler>();

        public void AddToChain(IHandler handler)
        {
            string handlerName = handler.GetType().Name;

            if (chain.ContainsKey(handlerName)) {
                throw new Exception();
            }

            chain.Add(handlerName, handler);
        }

        public void Execute(String handlerName)
        {
            if (chain.Count == 0) {
                throw new Exception();
            }

            if (chain.ContainsKey(handlerName)) {
                foreach(KeyValuePair<string, IHandler> entry in chain)
                {
                    IHandler handler = entry.Value;

                    handler.Execute();
                
                    if (handler.GetType().Name == handlerName) {
                        return;
                    }
                }
            }

            throw new Exception();
        }
    }
}
