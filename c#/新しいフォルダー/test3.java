package test;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class test3 {
	   public static void main(String args[]) {

	        try {
	            //ファイルを読み込む
	            FileReader fr = new FileReader("/home/students/v3033075/eclipse/java/workspace/mar6/test/src/test/name/name.txt");
	            BufferedReader br = new BufferedReader(fr);

	            //読み込んだファイルを１行ずつ画面出力する
	            String line ;
	            String []line2 ;
	            int count = 0;
	            
	            while ((line= br.readLine()) != null) {
	            	//  line2=line;
	                System.out.println(line);
	            }

	            //終了処理
	            br.close();
	            fr.close();

	        } catch (IOException ex) {
	            //例外発生時処理
	            ex.printStackTrace();
	        }
	    }
}
