using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix_Multiply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Multiply.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void MultiplyTest()
        {
            //hardcode data
            int row = 2;
            int column = 2;
            int[,] arr1 = { { 1, 2 },{ 3, 4 } };
            int[,] arr2 = { { 2, 4 }, { 5, 3 } };
            //creating object of class
            Class1 obj1 = new Class1();
            //expected output
            int[,] answer = { { 12, 10 }, { 26, 24 } };
            //calling library
            int [,] result=obj1.Multiply(arr1,arr2,row,column);
            //for loop for comparison
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    Assert.AreEqual(result[i,j], answer[i,j]);
                }
            }
            
        }
    }
}