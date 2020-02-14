/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

namespace Behavioral.ChainOfResponsibility
{
    public interface IChain
    {
        void AddToChain(IHandler handler);
        void Execute(string handlerName);
    }
}
