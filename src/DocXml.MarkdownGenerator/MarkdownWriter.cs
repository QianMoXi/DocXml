﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocXml.MarkdownGenerator
{
    public class MarkdownWriter
    {
        public StringBuilder sb = new StringBuilder();

        public void WriteH1(string text)
        {
            WriteLine("# " + text);
        }
        public void WriteH2(string text)
        {
            WriteLine("## " + text);
        }

        public void WriteTableTitle(params string[] text)
        {
            Write("| " + string.Join(" | ", text) + " |");
            Write("|" + string.Join("|", text.Select(x => "---")) + "|");
        }

        public void WriteTableRow(params string[] text)
        {
            Write("| " + string.Join(" | ", text.Select(EscapeSpecialChars)) + " |");
        }

        static string EscapeSpecialChars(string text)
        {
            if (text == null) return "";
            text = text.Replace("<", "\\<");
            text = text.Replace(">", "\\>");
            return text.Replace("\r\n", "<br>");
        }

        public void WriteLine(string text)
        {
            if (text != null) sb.AppendLine(text);
            sb.AppendLine();
            Console.WriteLine(text);
        }

        public void Write(string text)
        {
            if (text == null) return;
            sb.AppendLine(text);
            Console.WriteLine(text);
        }

        public string Bold(string text)
        {
            return "**" + text + "**";
        }

        public void WriteLink(string anchorName, string text)
        {
            sb.Append($"[{text}]({anchorName})");
        }
        public void WriteAnchor(string anchorName)
        {
            sb.Append($"<a name=\"{anchorName}\"></a>");
        }
    }
}