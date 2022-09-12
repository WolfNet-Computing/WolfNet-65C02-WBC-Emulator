﻿namespace Simulator.Model
{
	/// <summary>
	/// The Model used when Loading a Program.
	/// </summary>
	public class AssemblyFileModel
    {
        /// <summary>
        /// The Program Converted into Hex.
        /// </summary>
        public byte[] Rom { get; set; }

        /// <summary>
        /// The path of the Program that was loaded.
        /// </summary>
        public string RomFilePath { get; set; }

        /// <summary>
        /// The name of the Program that was loaded.
        /// </summary>
        public string RomFileName { get; set; }
    }
}
