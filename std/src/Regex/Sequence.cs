using S = System;
using G = System.Collections.Generic;
namespace TemperLang.Std.Regex
{
    public class Sequence: IRegexNode
    {
        readonly G::IReadOnlyList<IRegexNode> items__236;
        public Sequence(G::IReadOnlyList<IRegexNode> items__238)
        {
            this.items__236 = items__238;
        }
        public G::IReadOnlyList<IRegexNode> Items
        {
            get
            {
                return this.items__236;
            }
        }
        public Regex Compiled()
        {
            return IRegexNode.CompiledDefault(this);
        }
        public bool Found(string text___1381)
        {
            return IRegexNode.FoundDefault(this, text___1381);
        }
        public Match Find(string text___1383)
        {
            return IRegexNode.FindDefault(this, text___1383);
        }
        public string Replace(string text___1385, S::Func<Match, string> format___1386)
        {
            return IRegexNode.ReplaceDefault(this, text___1385, (S::Func<Match, string>) format___1386);
        }
        public G::IReadOnlyList<string> Split(string text___1388)
        {
            return IRegexNode.SplitDefault(this, text___1388);
        }
    }
}
