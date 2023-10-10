/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programa8;

import java.util.Scanner;

public class Programa8 {


    public static void main(String[] args) {
        Scanner it = new Scanner(System.in);
        double metros, pies;
        System.out.println("Programa para convertir metros a pies");
        System.out.print("Ingresa los metros: ");
        metros = it.nextInt();
        
        pies=metros* 3.281;
        

        
        System.out.println("El valor de metros es: "+metros);
    }
    
}
