using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Multiply
{
    public class Class1
    {
        //a FUNCTION which recieves two square matrices and row and column numbers
        public int[,] Multiply (int[,] a,int[,] b, int row,int column)
        {
            //new multidimensional matrix for the result
            int[,] result = new int[row, column];
            //first for loop for rows
            for (int i=0;i<row;i++)
            {
                //second for loop for traversing through columns
                for(int j=0;j<column;j++)
                {
                    //initializing result matrix with 0
                    result[i,j] = 0;
                    //third for loop for calculating results
                    for(int k=0; k<row; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            //returning result
            return result;
        }
    }
}
