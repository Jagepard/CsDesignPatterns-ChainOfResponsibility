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
        IDictionary<string, IHandlerInterface> chain = new Dictionary<string, IHandlerInterface>();

        public void AddToChain(IHandlerInterface handler)
        {
            string handlerName = handler.GetType().Name;

            if (this.chain.ContainsKey(handlerName)) {
                throw new Exception();
            }

            this.chain.Add(handlerName, handler);
        }

        public void Execute(String handlerName)
        {
            if (this.chain.Count == 0) {
                throw new Exception();
            }

            if (this.chain.ContainsKey(handlerName)) {
                foreach(KeyValuePair<string, IHandlerInterface> entry in this.chain)
                {
                    IHandlerInterface handler = entry.Value;

                    handler.execute();
                
                    if (handler.GetType().Name == handlerName) {
                        return;
                    }
                }
            }

            throw new Exception();
        }
    }
}
