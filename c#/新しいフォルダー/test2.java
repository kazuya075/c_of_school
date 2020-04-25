package test;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.Arrays;

public class test2 {
	private int row;
	private int col;
    static long lineCount = 0;
	 public static void main(String[] args) {
	        try {
	            //ファイルを読み込む
	            FileReader fr = new FileReader("/home/students/v3033075/eclipse/java/workspace/mar6/test/src/test/name/name.txt");
	            BufferedReader br = new BufferedReader(fr);

	            //読み込んだファイルを１行ずつ画面出力する
	            String line ;    
	            int count = 0;
	            
	            while ((line= br.readLine()) != null) {
	            	lineCount++;
	                System.out.println(line);
	            }

	            for (int i = 0; i < row; i++) {
	                line = br.readLine();
	                for (int j = 0; j < col; j++) {
	                    map[i][j] = Integer.parseInt(line.charAt(j) + "");
	                }
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

/*
 /* String[][] foo = {{"1163033134,Nakayama Takuma"}, {"1163033075,Koyanagi Kazuya"}, 
	        		{"1163033018,Ishibasi Yousuke"}, {"1163033151,Matunaga Daiki"}};
	         
         //ファイルを読み込む
         FileReader fr = new FileReader("/home/students/v3033075/eclipse/java/workspace/mar6/test/src/test/name/name.txt");
         BufferedReader br = new BufferedReader(fr);
	        
            // 行数を読み込む
           String line = br.readLine();
           while ((line= br.readLine()) != null) {
           	//  line2=line;
               System.out.println(line);
           }
          //  row = Integer.parseInt(line);
           
            // 列数を読み込む
          /*  line = br.readLine();
            col = Integer.parseInt(line);*/
	        
	        
	        
	        
	        //Arrays.sort(foo);
	        //(1)
	       /* for(int i = 0 ; i<= foo.length -1 ; i++){
	        	if(i<foo.length-1){
	        		System.out.println(foo[i]+",");   
              }else if(i==foo.length-1){
                System.out.println(foo[i]+"");    
                }
	        }
 * */
