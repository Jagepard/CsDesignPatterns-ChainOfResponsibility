/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace Behavioral.ChainOfResponsibility
{
    public class NoticeHandler : IHandler
    {
        public void Execute()
        {
            Console.WriteLine("{0}\n", this.GetType().Name);
        }
    }
}
