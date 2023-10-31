/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa6u3;

import java.util.Scanner;
public class Programa6U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num;
        System.out.println("Programa para saber si un numero es par o impar");
        System.out.println("Introdusca un numero");
        num = sc.nextInt();
        
        if (num%2==0){
            System.out.println("El numero es par");
            
        }else{
        System.out.println("El numero es impar");
        }
        
    }
}
