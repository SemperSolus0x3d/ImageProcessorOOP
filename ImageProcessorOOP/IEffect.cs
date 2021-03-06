namespace ImageProcessorOOP
{
    public interface IEffect
    {
        string Name { get; }

        void Apply(Image image);
    }
}