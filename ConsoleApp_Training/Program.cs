﻿using System;
using System.Diagnostics;

namespace ConsoleApp_Training
{
    class Program
    {



        static void Main(string[] args)
        {

            //Stopwatch stopwatch1 = new Stopwatch();
            //stopwatch1.Reset();
            //stopwatch1.Start();

            ////Merge_Sorted_Array.subMain();
            //Group_Anagrams.subMain(1);

            //stopwatch1.Stop();
            //Console.WriteLine(stopwatch1.ElapsedMilliseconds);

            //Stopwatch stopwatch2 = new Stopwatch();
            //stopwatch2.Reset();
            //stopwatch2.Start();

            //Group_Anagrams.subMain(2);

            //stopwatch2.Stop();
            //Console.WriteLine(stopwatch2.ElapsedMilliseconds);

            //Delegate
            //ClassDelegate classDelegate1 = new ClassDelegate();

            //Sort
            //Sort.Call();

            //Exo MDF_2018 Intérêts
            //string[] arg = {"17",
            //"130",
            //"-391",
            //"243",
            //"122",
            //"-1",
            //"144",
            //"349",
            //"307",
            //"-49",
            //"159",
            //"-114",
            //"354",
            //"-118",
            //"-89",
            //"-136",
            //"29",
            //"392",
            //"-114"};
            //Mdf2018_Interets.MainMdf2018(arg);

            //Exo MDF_2018 Saut à la perche
            //            string[] arg = {
            //             "203",
            //"xoajde 4.03 S",
            //"elbdzc 4.12 S",
            //"elbdzc 4.24 S",
            //"elbdzc 4.32 S",
            //"mhbrkd 4.32 S",
            //"xoajde 4.34 S",
            //"gyixau 4.39 S",
            //"mhbrkd 4.42 S",
            //"elbdzc 4.48 S",
            //"xoajde 4.48 S",
            //"gyixau 4.56 S",
            //"xoajde 4.59 S",
            //"mhbrkd 4.61 S",
            //"elbdzc 4.61 S",
            //"luczft 4.62 S",
            //"mhbrkd 4.66 S",
            //"xoajde 4.69 S",
            //"elbdzc 4.70 S",
            //"kqldje 4.70 S",
            //"nwcogk 4.71 S",
            //"luczft 4.74 S",
            //"gyixau 4.76 S",
            //"luczft 4.80 S",
            //"oybglc 4.82 S",
            //"mhbrkd 4.85 S",
            //"elbdzc 4.85 S",
            //"luczft 4.89 S",
            //"elbdzc 4.96 S",
            //"mhbrkd 4.98 S",
            //"wakbhu 5.00 S",
            //"gyixau 5.03 S",
            //"nwcogk 5.04 S",
            //"kqldje 5.06 S",
            //"xoajde 5.08 S",
            //"elbdzc 5.09 S",
            //"wakbhu 5.12 S",
            //"gyixau 5.15 S",
            //"nwcogk 5.22 S",
            //"kqldje 5.23 S",
            //"mhbrkd 5.24 S",
            //"luczft 5.26 S",
            //"gyixau 5.32 S",
            //"oybglc 5.34 S",
            //"elbdzc 5.36 S",
            //"wakbhu 5.37 S",
            //"kqldje 5.38 S",
            //"mhbrkd 5.39 S",
            //"luczft 5.40 S",
            //"xoajde 5.40 S",
            //"oybglc 5.42 S",
            //"kqldje 5.45 S",
            //"gyixau 5.46 S",
            //"wakbhu 5.46 S",
            //"elbdzc 5.52 S",
            //"mhbrkd 5.53 S",
            //"kqldje 5.53 S",
            //"wakbhu 5.54 S",
            //"nwcogk 5.58 S",
            //"oybglc 5.59 S",
            //"xoajde 5.60 S",
            //"gyixau 5.62 S",
            //"mhbrkd 5.63 S",
            //"oybglc 5.64 S",
            //"xoajde 5.66 S",
            //"wakbhu 5.70 S",
            //"gyixau 5.72 S",
            //"nwcogk 5.72 S",
            //"kqldje 5.72 S",
            //"elbdzc 5.79 S",
            //"mhbrkd 5.80 S",
            //"nwcogk 5.80 S",
            //"oybglc 5.82 S",
            //"xoajde 5.85 S",
            //"mhbrkd 5.86 S",
            //"mhbrkd 5.94 S",
            //"luczft 5.94 S",
            //"nwcogk 5.94 S",
            //"oybglc 5.95 S",
            //"elbdzc 5.97 S",
            //"luczft 6.01 S",
            //"wakbhu 6.03 E",
            //"wakbhu 6.03 S",
            //"xoajde 6.04 S",
            //"luczft 6.06 S",
            //"kqldje 6.06 S",
            //"nwcogk 6.07 S",
            //"oybglc 6.08 S",
            //"wakbhu 6.09 S",
            //"mhbrkd 6.11 S",
            //"nwcogk 6.14 S",
            //"elbdzc 6.16 S",
            //"kqldje 6.17 S",
            //"xoajde 6.17 S",
            //"gyixau 6.18 S",
            //"oybglc 6.20 S",
            //"mhbrkd 6.24 S",
            //"luczft 6.24 S",
            //"xoajde 6.24 S",
            //"nwcogk 6.27 S",
            //"kqldje 6.30 S",
            //"gyixau 6.32 S",
            //"elbdzc 6.34 S",
            //"luczft 6.35 S",
            //"kqldje 6.35 S",
            //"mhbrkd 6.37 E",
            //"mhbrkd 6.37 S",
            //"wakbhu 6.40 S",
            //"nwcogk 6.41 S",
            //"xoajde 6.44 E",
            //"xoajde 6.44 S",
            //"gyixau 6.48 E",
            //"gyixau 6.48 S",
            //"oybglc 6.49 S",
            //"xoajde 6.49 S",
            //"mhbrkd 6.50 E",
            //"mhbrkd 6.50 S",
            //"kqldje 6.52 S",
            //"elbdzc 6.53 S",
            //"kqldje 6.61 S",
            //"elbdzc 6.62 E",
            //"gyixau 6.67 S",
            //"nwcogk 6.68 S",
            //"oybglc 6.68 S",
            //"elbdzc 6.69 S",
            //"kqldje 6.71 S",
            //"mhbrkd 6.75 S",
            //"gyixau 6.75 E",
            //"gyixau 6.75 E",
            //"wakbhu 6.76 E",
            //"wakbhu 6.76 S",
            //"nwcogk 6.80 S",
            //"elbdzc 6.82 E",
            //"elbdzc 6.82 S",
            //"mhbrkd 6.83 E",
            //"mhbrkd 6.83 E",
            //"wakbhu 6.85 S",
            //"oybglc 6.86 E",
            //"oybglc 6.86 E",
            //"oybglc 6.86 E",
            //"gyixau 6.92 E",
            //"mhbrkd 6.93 S",
            //"kqldje 6.93 E",
            //"wakbhu 6.95 S",
            //"kqldje 6.98 E",
            //"nwcogk 7.00 E",
            //"nwcogk 7.00 S",
            //"xoajde 7.00 S",
            //"kqldje 7.05 E",
            //"luczft 7.07 S",
            //"mhbrkd 7.10 E",
            //"mhbrkd 7.10 S",
            //"nwcogk 7.15 E",
            //"nwcogk 7.15 S",
            //"mhbrkd 7.23 E",
            //"mhbrkd 7.23 S",
            //"wakbhu 7.24 S",
            //"elbdzc 7.24 S",
            //"luczft 7.24 E",
            //"luczft 7.24 S",
            //"xoajde 7.27 S",
            //"luczft 7.29 S",
            //"elbdzc 7.32 S",
            //"nwcogk 7.34 S",
            //"luczft 7.37 E",
            //"mhbrkd 7.40 S",
            //"elbdzc 7.40 E",
            //"elbdzc 7.40 S",
            //"nwcogk 7.45 E",
            //"wakbhu 7.49 S",
            //"luczft 7.49 E",
            //"elbdzc 7.51 E",
            //"elbdzc 7.51 E",
            //"elbdzc 7.51 S",
            //"mhbrkd 7.53 S",
            //"mhbrkd 7.63 E",
            //"mhbrkd 7.63 S",
            //"xoajde 7.64 S",
            //"wakbhu 7.67 E",
            //"wakbhu 7.67 S",
            //"elbdzc 7.69 E",
            //"elbdzc 7.69 S",
            //"nwcogk 7.69 E",
            //"nwcogk 7.69 E",
            //"xoajde 7.73 E",
            //"xoajde 7.73 S",
            //"wakbhu 7.85 S",
            //"luczft 7.86 E",
            //"mhbrkd 7.87 E",
            //"xoajde 7.98 E",
            //"xoajde 7.98 E",
            //"mhbrkd 8.02 S",
            //"wakbhu 8.04 S",
            //"elbdzc 8.05 S",
            //"xoajde 8.14 E",
            //"wakbhu 8.16 E",
            //"mhbrkd 8.21 E",
            //"wakbhu 8.29 E",
            //"wakbhu 8.29 E",
            //"elbdzc 8.34 E",
            //"elbdzc 8.34 E",
            //"elbdzc 8.46 E",
            //"mhbrkd 8.53 E",
            //"mhbrkd 8.53 E"

            //            };

            //            Mdf2018_Perche.MainMdf2018(arg);


            //LeetCodeTwoSum.test();

            //ClassShuffle.MainShuffle();

            Class_Reverse.MainReverse();

        }

    }
    }
