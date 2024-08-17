class Solution {
    public int strStr(String haystack, String needle) {
        if (haystack.length() < 1 || haystack.length() > 9999 || needle.length() < 1 || needle.length() > 9999) {
            return -1;
        }

        if (haystack.contains(needle)) {
            return haystack.indexOf(needle);
        }

        return -1;
    }
}
