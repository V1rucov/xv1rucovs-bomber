using System.Threading;
using System.Threading.Tasks;

namespace xv1Bomb
{
    public interface IObserveable {
        public Task Start(string phoneNumber,CancellationToken ct ,int repeat,int delay);
        public void AddObserver(IObserver o);
        public void RemoveObserver(IObserver o);
    }
}