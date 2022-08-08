public class Solution {
    public void revstr(int i, int j, char[] c)
    {
        char temp;
        while(i <= j)
        {
            temp = c[i];
            c[i] = c[j];
            c[j] = temp;
            i++;
            j--;
        }
    }
    public string ReverseWords(string s) {
        int i = 0;
        int j = 0;
        char[] myCharArr = s.ToCharArray();
        int y = s.Length;
        
        while(j <= y)
        {
            if(j == y || myCharArr[j] == ' ')
            {
                revstr(i, j - 1, myCharArr);
                i = j + 1;
                j += 1;
            }
            else
            {
                j++;
            }
        }
        
        String str = new String(myCharArr);
        return str;
    }
}