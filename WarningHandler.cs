/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace Behavioral.ChainOfResponsibility
{
    public class WarningHandler : HandlerInterface
    {
        public void execute()
        {
            Console.WriteLine("{0}\n", this.GetType().Name);
        }
    }
}
