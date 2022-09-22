using System.Text.RegularExpressions;

namespace Assignment2;

public static class Extensions

{
    public static bool IsSecure(this Uri url){
        if(url.Scheme == Uri.UriSchemeHttps) {
            return true;
        }
        return false;

    }


    public static int WordCount(this string str) {
        var pattern =@"^\p{L}+$";
        var count = 0;
        foreach (string s in str.Split(new[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries)){
            if(Regex.IsMatch(s, pattern)){
                count++;
            }
        }
        return count;
        
    }
}
