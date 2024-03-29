﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace OSProject
{
    public class Memory
    {
        public List<Hole> Holes;

        public List<Segment> Segments => Processes.SelectMany(p => p.Segments).ToList();
        public List<Process> Processes;
        public int Size { get; set; }

        public BindingList<Hole> HolesBindingList => new BindingList<Hole>(Holes);
        public BindingList<Segment> SegmentsBindingList => new BindingList<Segment>(Segments);

        public int AllocationMethod { get; set; }

        public Memory()
        {
            Holes = new List<Hole>();
            Processes = new List<Process>();
        }

        public bool AddHole(Hole hole)
        {
            /****Error checking*****/
            //Hole starting address is valid
            if (hole.StartAddress < 0)
            {
                MessageBox.Show(@"The hole starting address cannot be less than zero.");
                return false;
            }
            //Check the hole size it less than the memory size (with starting address in consideration)
            if (hole.StartAddress + hole.Size > Size)
            {
                MessageBox.Show(@"The hole size will not fit in this memory! Please change the size or the starting address of the hole.");
                return false;
            }
            //Check Hole size is not less than or equal zero
            if (hole.Size <= 0)
            {
                MessageBox.Show(@"How can a hole size be zero or less? It's a mistake right? Please modify the hole size.");
                return false;
            }
            //Check interfering with other holes
            foreach (var h in Holes)
            {
                //Check the starting address is not inside another hole already!
                if (Enumerable.Range(h.StartAddress,h.Size+1)
                    .Contains(hole.StartAddress))
                {
                    var sizeToAdd = hole.Size - (h.StartAddress + h.Size - hole.StartAddress);
                    if (sizeToAdd > 0)
                        h.Size += sizeToAdd;
                    MessageBox.Show(@"The hole starting address is inside another hole already! So, we extended the previous hole ;)");
                    return true;
                }
                //Check if the hole's end will overlap another hole!
                if (Enumerable.Range(hole.StartAddress,hole.Size+1)
                    .Contains(h.StartAddress))
                {
                    //Check if the old hole is fully included in the new one
                    if (Enumerable.Range(hole.StartAddress, hole.Size + 1)
                        .Contains(h.StartAddress + h.Size))
                    {

                        if (h.FreeIndex == h.StartAddress)
                            h.FreeIndex = hole.StartAddress;
                        h.StartAddress = hole.StartAddress;
                        h.Size = hole.Size;
                    }
                    else
                    {
                        var sizeToSubtract = hole.StartAddress + hole.Size - h.StartAddress;
                        if (sizeToSubtract > 0)
                            h.Size += hole.Size - sizeToSubtract;
                        if (h.FreeIndex == h.StartAddress)
                            h.FreeIndex = hole.StartAddress;
                        h.StartAddress = hole.StartAddress;
                    }

                    MessageBox.Show(@"Another hole's starting address will be inside this hole! So, we modified the previous hole's starting address, and extended its size ;)");

                    //Check if there is any processes allocated
                    if (Processes.Count(p => p.Allocated) > 0)
                    {
                        var allocatedProcesses = Processes.Where(p => p.Allocated).ToList();
                        DeallocateAll();
                        //Reallocate them
                        foreach (var process in allocatedProcesses)
                        {
                            if (!TryAllocateProcess(process))
                            {
                                MessageBox.Show(@"The Process " + process.Name + @" cannot be reallocated for now!");
                            }
                        }
                    }
                    return true;
                }
            }

            //All checks done! Let's add the hole
            Holes.Add(hole);
            return true;
        }
        public void Reset()
        {
            Holes.Clear();
            Segments.Clear();
            Processes.Clear();
            Size = 0;
        }

        public bool TryAllocateProcess(Process process)
        {
            var segmentNotAllocated = false;
            foreach (var segment in process.Segments)
            {
                switch (AllocationMethod)
                {
                    /*
                     * 0- First Fit
                     * 1- Best Fit
                     * 2- Worst Fit
                     */
                    case 0: //First Fit
                        Holes = Holes.OrderBy(h => h.StartAddress).ToList();
                        break;
                    case 1: //Best Fit
                        Holes = Holes.OrderBy(h => h.AvailableSize).ThenBy(h => h.StartAddress).ToList();
                        break;
                    case 2: //Worst Fit
                        Holes = Holes.OrderByDescending(h => h.AvailableSize).ToList();
                        break;
                }


                if (Holes.Count(hole => hole.AvailableSize >= segment.Size) > 0)
                {
                    var hole = Holes.First(h => h.AvailableSize >= segment.Size);
                    segment.Allocate(hole);
                }
                else
                {
                    //Not Fitting!
                    segmentNotAllocated = true;
                    break;
                }
            }

            if (segmentNotAllocated)
            {
                //Deallocate any previously allocated segments
                foreach (var segment in process.Segments.Where(s => s.IsAllocated))
                {
                    var index= Holes.FindIndex(h => h == segment.Hole);
                    Holes[index] = segment.Deallocate();

                }

                return false;
            }

            return true;
        }

        public void DeallocateAll()
        {
            foreach (var segment in Processes.SelectMany(p => p.Segments))
            {
                segment.Deallocate();
            }
        }
    }
}
