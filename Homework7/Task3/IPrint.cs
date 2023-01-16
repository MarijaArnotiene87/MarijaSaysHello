namespace Homework7.Task3
{
    public interface IPrint
    {
        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }

        public void Print();
    }
}
