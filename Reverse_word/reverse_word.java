class Solution {
    public void reStr(int i, int j, char[] s)
    {
        char temp;
        while(i <= j)
        {
            temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            
            i++;
            j--;
        }
    }
    public String reverseWords(String s) {
        int i = 0;
        int j = 0;
        char[] myCharArr = s.toCharArray();
        int y = s.length();
        
        while(j <= y)
        {
            if(j == y || myCharArr[j] == ' ')
            {
                reStr(i, j - 1, myCharArr);
                i = j + 1;
                j += 1;
            }
            else
            {
                j++;
            }
        }
        
        String str = String.valueOf(myCharArr);
        return str;
    }
}