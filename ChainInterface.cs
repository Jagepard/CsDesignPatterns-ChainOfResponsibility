/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

namespace Behavioral.ChainOfResponsibility
{
    public interface ChainInterface
    {
        void addToChain(HandlerInterface handler);
        void execute(string handlerName);
    }
}
