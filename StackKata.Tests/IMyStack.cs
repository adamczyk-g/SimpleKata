
namespace StackKata.Tests
{
    public interface IMyStack<T>
    {
        T Pop();
        void Push(T item);
        T Peak();
        void Clear();
        int Count();
        bool IsEmpty();
    }
}
