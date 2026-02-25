using S = System;
using G = System.Collections.Generic;
namespace TemperLang.Std.Regex
{
    public class Capture: IRegexNode
    {
        readonly string name__184;
        readonly IRegexNode item__185;
        public Capture(string name__187, IRegexNode item__188)
        {
            this.name__184 = name__187;
            this.item__185 = item__188;
        }
        public string Name
        {
            get
            {
                return this.name__184;
            }
        }
        public IRegexNode Item
        {
            get
            {
                return this.item__185;
            }
        }
        public Regex Compiled()
        {
            return IRegexNode.CompiledDefault(this);
        }
        public bool Found(string text___1321)
        {
            return IRegexNode.FoundDefault(this, text___1321);
        }
        public Match Find(string text___1323)
        {
            return IRegexNode.FindDefault(this, text___1323);
        }
        public string Replace(string text___1325, S::Func<Match, string> format___1326)
        {
            return IRegexNode.ReplaceDefault(this, text___1325, (S::Func<Match, string>) format___1326);
        }
        public G::IReadOnlyList<string> Split(string text___1328)
        {
            return IRegexNode.SplitDefault(this, text___1328);
        }
    }
}
