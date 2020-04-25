package test2;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
//http://asistobe851.web.fc2.com/my-memo/sort.html
public class test3 {
    public static void main(String[] args) {
    	String[][] nums;
   	 //String[] name;
   	 List<String> temp = new ArrayList<String>();

     try (BufferedReader br = new BufferedReader(new FileReader("C:\\Users\\fmv\\Desktop\\pleiades\\workspace\\pro\\src\\test2\\name\\name.txt"))){
            String line;
            //ファイルから読み込んだ行を一旦リストに入れておく
            while((line = br.readLine()) != null){
                temp.add(line);
            }

            nums = new String[temp.size()][2];
            //文字列を空白で分割し，配列に格納
            for(int i = 0; i < temp.size(); i++){
                String[] s = temp.get(i).split(" ", 2);
                for(int j = 0; j < 2; j++){
                    nums[i][j] = s[j];
                }
            }
            TheComparator comparator = new TheComparator();

            // 2番目の項目でソートするように設定
            comparator.setIndex(1);
            // ソート実施
            Arrays.sort( nums, comparator );
            // ソート結果を出力

            for(int i = 0; i < temp.size(); i++){
                System.out.println(Arrays.toString(nums[i]));
            }
        }catch (IOException e){
            e.printStackTrace(); }
   }
}
