using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSProject
{
    public class Process
    {
        public int SegmentsCount { get; set; }

        public List<Segment> Segments;

        public int Number { get; set; }

        public string Name => "Process " + Number;

        public bool Allocated => IsAllocated();


        public Process(int segmentsCount,int number,List<Segment> segments = null)
        {
            SegmentsCount = segmentsCount;
            Number = number;
            Segments = segments ?? new List<Segment>();
        }

        private bool IsAllocated()
        {
            foreach (var segment in Segments)
            {
                if (!segment.IsAllocated)
                {
                    return false;
                }
            }

            return true;
        }

        public bool AddSegment(string name, int size)
        {
            //Check if the process didn't get all its segments' data
            if (Segments.Count >= SegmentsCount)
            {
                MessageBox.Show(@"Sorry, but you've already entered data for all segments of this process!");
                return false;
            }
            //Check segment has meaningful size
            if (size < 1)
            {
                MessageBox.Show(@"Segment size cannot be Zero! Please, enter a more logic size.");
                return false;
            }
            //Set a default name if no name provided
            if (name.Length < 1)
            {
                name = "Segment " + Segments.Count;
            }
            //Add the segment if passed all above
            Segments.Add(new Segment(name,size,Name));
            return true;
        }

        public bool HasAllData()
        {
            return Segments.Count == SegmentsCount;
        }
    }
}
