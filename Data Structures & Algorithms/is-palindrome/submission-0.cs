public class Solution {
    public bool IsPalindrome(string s) {
        int i=0; 
        int j= s.Length-i-1;
        while(i<j){
            if(IsAscii(s[i])&&(IsAscii(s[j]))){

                if(Char.ToLower(s[i])!= Char.ToLower(s[j])) return false;
            }
            else{
                if(!IsAscii(s[i])) {i++; continue;}
                if(!IsAscii(s[j])) {j--; continue;}
            }
            i++;
            j--;
        }
        return true;
    }
    public bool IsAscii(char c){
        return ((c >= 'A' && c<='Z')||(c>='a'&&c<='z')||(c>='0'&&c<='9'));
    }
}
