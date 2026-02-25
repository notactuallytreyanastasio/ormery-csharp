using S = System;
using G = System.Collections.Generic;
namespace TemperLang.Std.Regex
{
    class Space: ISpecialSet
    {
        public Space()
        {
        }
        public Regex Compiled()
        {
            return IRegexNode.CompiledDefault(this);
        }
        public bool Found(string text___1441)
        {
            return IRegexNode.FoundDefault(this, text___1441);
        }
        public Match Find(string text___1443)
        {
            return IRegexNode.FindDefault(this, text___1443);
        }
        public string Replace(string text___1445, S::Func<Match, string> format___1446)
        {
            return IRegexNode.ReplaceDefault(this, text___1445, (S::Func<Match, string>) format___1446);
        }
        public G::IReadOnlyList<string> Split(string text___1448)
        {
            return IRegexNode.SplitDefault(this, text___1448);
        }
    }
}
