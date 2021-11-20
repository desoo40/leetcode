
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution_451 {
    public string FrequencySort(string s) {
        
        var dict = new Dictionary<char, string>();

        foreach (var el in s)
            if (dict.ContainsKey(el))
                dict[el] += el;
            else
                dict[el] = el.ToString();

        var vals = dict.Values;

        var sort = vals.OrderBy(x => -x.Length);

        return String.Join("",sort);;
    }
}