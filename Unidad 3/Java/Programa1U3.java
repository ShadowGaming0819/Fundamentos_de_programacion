/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa1u3;

import java.util.Scanner;

public class Programa1U3 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        System.out.println("Programa para saber si eres mayor o menor de edad");
        int edad;
        
        System.out.println("Introduce tu edad");
        edad=sc.nextInt();
        
        if (edad >= 18){
            System.out.println("Eres mayor de edad");
        
        }else{
            System.out.println("Eres menor de edad");
        }
        
    }
}
