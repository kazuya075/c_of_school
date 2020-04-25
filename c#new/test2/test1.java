package test2;

//https://java-reference.com/java_collection_sort_string.html
//integer 昇順 java
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;

public class test1 {
    private static String t=null;

	public static void main(String[] args) {

        try (BufferedReader br = new BufferedReader(new FileReader("C:\\Users\\fmv\\Desktop\\pleiades\\workspace\\pro\\src\\test2\\name\\test.txt"))){

            t =br.readLine();
            String[] numStrings = t.split(" ");

            ArrayList<Integer> numbers = new ArrayList<Integer>();//arraylistに数値を入れる

            for(String str : numStrings){
                int num = Integer.parseInt(str);
                numbers.add(num);
            }

            System.out.println("正順 "+numbers);
            Collections.reverse(numbers);
            System.out.println("逆順 "+numbers);
            Collections.sort(numbers);
            System.out.println("昇順 " +numbers);
            Collections.reverse(numbers);
            System.out.println("降順 "+numbers);



        }catch (IOException e){
            e.printStackTrace();
        }

   }
}
