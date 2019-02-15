﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoxSmoke.DocXml
{
    /// <summary>
    /// Class, Struct or  delegate comments
    /// </summary>
    public class TypeComments : CommonComments
    {
        /// <summary>
        /// This list contains descriptions of delegate type parameters. 
        /// For non-delegate types this list is empty.
        /// For delegate types this list contains tuples where 
        /// Item1 is the "param" item "name" attribute and
        /// Item2 is the body of the comment
        /// </summary>
        public List<(string Name, string Text)> Parameters { get; set; } = new List<(string Name, string Text)>();
    }
}
