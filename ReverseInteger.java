class Solution {
    public int reverse(int x) {
        int rvrs = 0;
        int prevRN = 0;
        while (x != 0) {
            System.out.println("rvrs: " + rvrs);
            rvrs = (rvrs * 10) + (x % 10);
            if ((rvrs - (x % 10))/10 != prevRN) {
                System.out.println("rvrs - (x %10): " + (rvrs - (x % 10)) / 10 + " != " + prevRN);
                return 0;
            }
            x = x / 10;
            prevRN = rvrs;
        }
        return rvrs;
    }
}
