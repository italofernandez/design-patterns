namespace Builder
{
    public interface IBuilder<T> where T : class
    {
        public T Product { get; set; }
        T Build();
        void Reset();
    }
}
