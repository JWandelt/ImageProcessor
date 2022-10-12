﻿using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Processor
{
    public class CommandLineOptions
    {
        [Value(index: 0, Required = true, HelpText = "Full path to an image that you want to process.")]
        public string loadPath { get; set; }
        [Value(index: 1, Required = true, HelpText = "Full path to where you want to save the image", Default = "@C:\\")]
        public string savePath { get; set; }

        //[Option(shortName: 'c', longName: "confidence", Required = false, HelpText = "Minimum confidence.", Default = 0.9f)]
        //public string Confidence { get; set; }
    }
}
