/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

namespace Behavioral.ChainOfResponsibility
{
    public interface IChain
    {
        void Execute(string request);
    }
}
