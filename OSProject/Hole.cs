using System.ComponentModel;

namespace OSProject
{
    public class Hole
    {
        [DisplayName("Start Addr")]
        public int StartAddress { get; set; }
        public int Size { get; set; }
        [Browsable(false)]
        public int AvailableSize => (StartAddress + Size) - FreeIndex;
        [Browsable(false)]
        public int FreeIndex { get; set; }

        [DisplayName("End Addr")]
        public int EndAddress => StartAddress + Size;

        public Hole(int startAddress, int size)
        {
            StartAddress = startAddress;
            Size = size;
            FreeIndex = StartAddress;
        }
    }
}