using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommentCleanTool
{
    class ListViewColumnSorter : IComparer
    {
        private int ColumnToSort;
        private SortOrder OrderOfSort;
        private CaseInsensitiveComparer ObjectCompare;
        public ListViewColumnSorter()
        {
            ColumnToSort = 0;
            OrderOfSort = SortOrder.None;
            ObjectCompare = new CaseInsensitiveComparer();
        }


        
        
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;
            
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            
            int xInt, yInt;
            string xText = listviewX.SubItems.Count > ColumnToSort ? listviewX.SubItems[ColumnToSort].Text : "";
            string yText = listviewY.SubItems.Count > ColumnToSort ? listviewY.SubItems[ColumnToSort].Text : "";
 
            if (int.TryParse(xText, out xInt) && int.TryParse(yText, out yInt)) 
            {
                
                compareResult = CompareInt(xInt, yInt);
            }
            else
            {
                
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
            }
            


            
            if (OrderOfSort == SortOrder.Ascending)
            {   
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {  
                return (-compareResult);
            }
            else
            {
                
                return 0;
            }
        }
        private int CompareInt(int x, int y)
        {
            if (x > y)
            {
                return 1;
            }
            else if (x < y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        
        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }
        
        public SortOrder Order
        {
            set
            {
                OrderOfSort = value;
            }
            get
            {
                return OrderOfSort;
            }
        }
    }
}
