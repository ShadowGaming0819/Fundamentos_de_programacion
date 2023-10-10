/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programa11;

import java.util.Scanner;

public class Programa11 {

    public static void main(String[] args) {
       Scanner it = new Scanner(System.in);
        int edad;
        System.out.println("Determina si eres mayor o menor de edad");
        System.out.print("Ingresa tu edad: ");
        edad= it.nextInt();
        if (edad >= 18){
                   System.out.println("Eres mayor de edad ");
            
        }else{
                System.out.println("Eres menor de edad ");
        }
        
                              
    }
    
}
