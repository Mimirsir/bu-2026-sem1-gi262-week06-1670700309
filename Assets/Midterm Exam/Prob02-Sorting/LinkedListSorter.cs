using System.Collections.Generic;
using Unity.GraphToolkit.Editor;
using Unity.VisualScripting;
using UnityEngine;


namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            if (list == null || list.Count < 2) ;
            {

                bool swapped = true;

                while (swapped)
                {
                    swapped = false;
                    var node = list.First;
           
                    while(true)
                    {
                        if (node.Next == null)
                        { 
                            break;
                        }

                        if (node.Value > node.Next.Value)
                        {
                            int temp = node.Value;
                            node.Value = node.Next.Value;
                            node.Value = temp;
                            swapped = true;
                        }
                        node = node.Next;
                    }
                }
                return list;
            }



        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            if (list == null || list.Count < 2) ;
            {

                bool swapped = true;

                while (swapped)
                {
                    swapped = false;
                    var node = list.First;

                    while (true)
                    {
                        if (node.Next == null)
                        {
                            break;
                        }

                        if (node.Value < node.Next.Value)
                        {
                            int temp = node.Value;
                            node.Value = node.Next.Value;
                            node.Value = temp;
                            swapped = true;
                        }
                        node = node.Next;
                    }
                }
                return list;
            }
        }
    }
}
