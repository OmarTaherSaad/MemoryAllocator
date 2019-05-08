using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject
{
    public class Segment
    {
        public string Name { get; set; }
        [Editable(false)]
        public int Size { get; set; }
        [Browsable(false)]
        public bool IsAllocated => isAllocated();
        [Browsable(false)]
        public int AllocationStart;
        [Browsable(false)]
        public int AllocationEnd => AllocationStart + Size;
        [DisplayName(("Process"))]
        [Editable(false)]
        public string ProcessName { get; set; }
        [Browsable(false)]
        public Hole Hole { get; set; }

        public Segment(string name, int size,string processName, int allocationStart = -1)
        {
            Name = name;
            Size = size;
            ProcessName = processName;
            AllocationStart = allocationStart;
            Hole = null;
        }

        private bool isAllocated()
        {
            if (AllocationStart != -1)
            {
                return true;
            }
            return false;
        }

        public void Allocate(Hole hole)
        {
            AllocationStart = hole.FreeIndex;
            hole.FreeIndex += Size;
            Hole = hole;
        }

        public Hole Deallocate()
        {
            AllocationStart = -1;
            Hole.FreeIndex -= Size;
            return Hole;
        }
    }
}
