/*Java Program - To print 2 integer and 
2 double values should add and 
concatenation of 2 strings*/

import java.util.*;
public class Solution{
   public static void main(String[] args)
  {
        int i1,i = 4;
        double d1,d = 4.0;
        String s = "  HackerRank ";
        String s1;		
        Scanner scan = new Scanner(System.in);
         i1=scan.nextInt(); 
         d1=scan.nextDouble();
          scan.nextLine();
         s1=scan.nextLine();
         System.out.println(i+i1);
         System.out.println(d+d1);
             System.out.print(s+s1);
 scan.close();
    }
}
