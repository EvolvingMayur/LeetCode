using System;

public partial class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {

        var map = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.TryGetValue(key, out var list))
            {
                list = [];
                map[key] = list;
            }
            list.Add(str);
        }

        return [.. map.Values];

        // if (strs.Length == 1)
        // {
        //     return [[.. strs]];
        // }
        // List<IList<string>> resultList = [[strs[0]]];
        // for (int i = 1; i < strs.Length; i++)
        // {
        //     var added = false;
        //     for (int j = 0; j < resultList.Count; j++)
        //     {
        //         if (IsAnagram(strs[i], resultList[j][0])) // used from Valid Anagram
        //         {
        //             added = true;
        //             resultList[j].Add(strs[i]);
        //             break;
        //         }
        //     }
        //     if (!added)
        //     {
        //         resultList.Add([strs[i]]);
        //     }
        // }
        // return resultList;

    }
    
}
