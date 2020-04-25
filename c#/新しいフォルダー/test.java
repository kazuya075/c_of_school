package test;


	import java.util.*;
	import java.util.Arrays;
	import java.util.Collections;

	public class test {
	    public static void main(String[] args) throws Exception {
	      
		        int[] foo = {10, 30, 5, 2, 11, 90};
		        

		        for(int i = 0 ; i<= foo.length -1 ; i++){
		        if(i==0) {
		        	System.out.print("正順 ["+foo[i]+",");
		        	}else if(i<foo.length-1){
		        		System.out.print(foo[i]+",");   
	              }else if(i==foo.length-1){
	                System.out.println(foo[i]+"]");    
	                }
		        }
		        for(int i = foo.length -1 ; i>=0; i--){
		        	if(i==foo.length-1) {
		        	System.out.print("逆順 ["+foo[i]+",");
		        	}else if(i>0){
	                System.out.print(foo[i]+",");    
	              }else if(i==0){
	                System.out.println(foo[i]+"]");    
	                }
		        }
		        Arrays.sort(foo);
		       
		        System.out.println("昇順 " + Arrays.toString(foo));
		        
		        for(int i = foo.length -1 ; i>=0; i--){
		        	if(i==foo.length-1) {
		        	System.out.print("降順 ["+foo[i]+",");
		        	}else if(i>0){
	                System.out.print(foo[i]+",");    
	              }else if(i==0){
	                System.out.println(foo[i]+"]");    
	                }
		        }
		        
		    }
	
}
