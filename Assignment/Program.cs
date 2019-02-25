﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment
{
    /*
    * CSD 3354 SECTION 3
    * ASIGNMENT ONE
    * TEAM MEMBERS:
    * Saksham Saksham C0732116
    * Manjot Kaur C0732136
    * Gurcharanjit Singh C0731812
    * Harman Singh C0725563
    */
    class JournalEntry
    {
        public JournalEntry(string note, int dist)
        {
            villageName = note; distanceTraveled = dist;
            HowFarToGetBack = distanceTraveled;
        }
        public int HowFarToGetBack = 0;
        private string villageName;
        private int distanceTraveled;
        public int getDistanceWalked() { return distanceTraveled; }
        public string getVillageName() { return villageName; }
    }

    class Hugi
    {
        private static JournalEntry je;
        public static bool FoundAstrilde = false;

        public static List<JournalEntry> HugiJournal = new List<JournalEntry>();

        public static int CalculateDistanceWalked()
        {
            int DistanceWalked = 0;
            // walk over the List and add the distances
            foreach (var je in HugiJournal)
            {
                Console.WriteLine(" {0}  --   {1} *** --- {2} ", je.getDistanceWalked(), je.getVillageName(), je.HowFarToGetBack);
                DistanceWalked += je.getDistanceWalked() + je.HowFarToGetBack;
            }
            return DistanceWalked;
        }
    }

}
