/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa13u3;

import java.util.Scanner;


public class Programa13U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
          int c, num, contadorp=1,contadorn=1; 

        for (c=1; c<=100; c++){
            System.out.println("Escribe el numero: ");
            num = sc.nextInt();
            
            if(num > 0){
                System.out.println("Son: "+ contadorp+" numeros positivos");
                contadorp=contadorp+1;  
            }else{
                System.out.println("Son: "+ contadorn+" numeros negativos");
                contadorn=contadorn+1;
            }
    }
}
    }
