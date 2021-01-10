using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FinalProject
{
    public class MapReduce
    {
		private string text;
		private ConcurrentBag<KeyValuePair<string, int>> valuePairs;
		private ConcurrentDictionary<string, List<int>> suffled;
		private ConcurrentDictionary<string, int> reduce;

		public MapReduce(string text)
		{
			this.text = text;
			Mapping();
			Shuffling();
			Reduce();

		}

		public void Mapping()
        {
			this.valuePairs = new ConcurrentBag<KeyValuePair<string, int>>();
			Parallel.ForEach(this.text.Split(' ', ',','.','\n'), (word) =>
			  {
				  valuePairs.Add(new KeyValuePair<string, int>(word.ToLower(),1));
			  }); 

		}

		public void Shuffling()
        {
			this.suffled = new ConcurrentDictionary<string, List<int>>();
			Parallel.ForEach(this.valuePairs, (word) =>
			{
				if (this.suffled.ContainsKey(word.Key))
                {
					this.suffled[word.Key].Add(1);
                }
                else
				{
					this.suffled.TryAdd(word.Key, new List<int> { 1 });
                }

			});


		}

		public void Reduce()
		{
			this.reduce = new ConcurrentDictionary<string, int>();
			Parallel.ForEach(this.suffled, (pair) =>
			{
				int nb = 0;
				Parallel.ForEach(pair.Value, (value) =>
				 {
					 nb += value;
				 });
				this.reduce.TryAdd(pair.Key, nb);
			});
		}


        public override string ToString()
        {
			string result = "";
			Parallel.ForEach(this.reduce, (entry) =>
			{
				Dictionary<string,int> words= new Dictionary<string, int>();
				words.Add(entry.Key, entry.Value);

				Parallel.ForEach(words, (pair) =>
				{
					result += string.Format(pair.Key + " : " + pair.Value + "\n");
				});

			});
			return result;
		}

	}
}
