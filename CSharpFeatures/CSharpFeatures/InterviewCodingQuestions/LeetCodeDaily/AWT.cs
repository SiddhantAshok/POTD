using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    public class AWT
    {
        //Question:        There is a restaurant with a single chef.You are given an array customers, where customers[i] = [arrivali, timei]:

        //arrivali is the arrival time of the ith customer.The arrival times are sorted in non-decreasing order.
        //timei is the time needed to prepare the order of the ith customer.
        //When a customer arrives, he gives the chef his order, and the chef starts preparing it once he is idle.The customer waits till the chef finishes preparing his order. The chef does not prepare food for more than one customer at a time.The chef prepares food for customers in the order they were given in the input.

        //Return the average waiting time of all customers. Solutions within 10-5 from the actual answer are considered accepted.


        public static double AverageWaitingTime(int[][] customers)
        {
            double totalWaitingTime = 0;
            double currentTime = 0;

            //for (int i = 0; i < customers.Length; i++)
            //{
            //    double arrivalTime = customers[i][0];
            //    double timeTaken = customers[i][1];

            //    if (i == 0)
            //    {
            //        currentTime += arrivalTime + timeTaken;
            //    }
            //    else
            //    {
            //        if (currentTime > arrivalTime)
            //        {
            //            currentTime += timeTaken;
            //        }
            //        else
            //        {
            //            currentTime = arrivalTime + timeTaken;
            //        }
            //    }
            //    if (currentTime > arrivalTime)
            //    {
            //        totalWaitingTime += currentTime - arrivalTime;
            //    }
            //    else
            //    {
            //        totalWaitingTime += timeTaken;
            //    }
            //}


            //------------
            for (int i = 0; i < customers.Length; i++)
            {
                double arrivalTime = customers[i][0];
                double timeTaken = customers[i][1];
                // Update currentTime based on the greater of currentTime or arrivalTime
                currentTime = Math.Max(currentTime, arrivalTime) + timeTaken;

                // Add the waiting time for this customer
                totalWaitingTime += currentTime - arrivalTime;
            }
            //-------------
            return totalWaitingTime / customers.Length;

        }
    }
}
