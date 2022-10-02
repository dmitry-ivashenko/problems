
// 929. Unique Email Addresses
// https://leetcode.com/problems/unique-email-addresses/
// Difficulty: Easy

public class Solution {
    public int NumUniqueEmails(string[] emails) 
	=> emails.Select(x => x.Split('@')).
              Select(split => split[0].
              Split('+')[0].
              Replace(".", "") + "@" + split[1]).
              Distinct().
              Count();
}
        