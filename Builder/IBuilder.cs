namespace Builder
{
    public interface IBuilder<T> where T : class
    {
        T Build();
        void Reset();
    }
}
