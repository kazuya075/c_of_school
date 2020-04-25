package test2;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
//https://teratail.com/questions/76008
//https://teratail.com/questions/16077

public class test2 {

	 public static void main(String[] args) {

		 String[] nums = null;
         List<String> temp = new ArrayList<String>();

         try (BufferedReader br = new BufferedReader(new FileReader("C:\\Users\\fmv\\Desktop\\pleiades\\workspace\\pro\\src\\test2\\name\\name.txt"))){
             String line;
             //ファイルから読み込んだ行を一旦リストに入れておく
             while((line = br.readLine()) != null){
                 temp.add(line);
             }
             //配列を読み込んだ行数で用意
             nums = new String[temp.size()];
             //配列に格納
             for(int i = 0; i < temp.size(); i++){
                     nums[i] = temp.get(i);
             }

         }catch (IOException e){
             e.printStackTrace();
         }

         Arrays.sort(nums);
	        //(1)
	        for(int i = 0 ; i<= nums.length -1 ; i++){//一行ごとに段落分け
	        	if(i<=nums.length-1){
	        		System.out.println(nums[i]+""); }
	        }
	    }

}
