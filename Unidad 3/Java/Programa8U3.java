/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa8u3;

import java.util.Scanner;
public class Programa8U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num1, num2;
        System.out.println("Programa para saber cual numero es mayor");
        System.out.println("Introdusca el primer numero");
        num1 = sc.nextInt();
        System.out.println("Introdusca el segundo numero");
        num2 = sc.nextInt();
        
        if(num1 > num2){
             System.out.println("El numero "+num1+" es mayor que "+num2);
        }else{
             System.out.println("El numero "+num2+" es menor que "+num1);
        }
        
        
    }
}
