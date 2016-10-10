/* package codechef; // don't place package name! */

import java.util.*;
import java.lang.*;
import java.io.*;

/* Name of the class has to be "Main" only if the class is public. */
class Codechef
{
	public static void main (String[] args) throws java.lang.Exception
	{
		Scanner scanner = new Scanner(new InputStreamReader(System.in));
		String input = scanner.nextLine();
		String[] split = input.split("\\s");
		String answer = "";
		for (int i = 0; i < split.length; i++){
		    answer = answer.concat(split[i]);
		}
//		System.out.println(answer);

        String[] splitOrder = answer.split("");
        answer = "";
        Arrays.sort(splitOrder);
        for (int i = 0; i < splitOrder.length; i++){
            answer = answer.concat(splitOrder[i]);
        }
        System.out.println(answer);
	}
}
