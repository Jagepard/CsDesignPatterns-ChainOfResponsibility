/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;
using System.Collections.Generic;

namespace Behavioral.ChainOfResponsibility
{
    public class Chain : ChainInterface
    {
        IDictionary<string, HandlerInterface> chain = new Dictionary<string, HandlerInterface>();

        public void addToChain(HandlerInterface handler)
        {
            string handlerName = handler.GetType().Name;

            if (this.chain.ContainsKey(handlerName)) {
                throw new Exception();
            }

            this.chain.Add(handlerName, handler);
        }

        public void execute(String handlerName)
        {
            if (this.chain.Count == 0) {
                throw new Exception();
            }

            if (this.chain.ContainsKey(handlerName)) {
                foreach(KeyValuePair<string, HandlerInterface> entry in this.chain)
                {
                    HandlerInterface handler = entry.Value;

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
