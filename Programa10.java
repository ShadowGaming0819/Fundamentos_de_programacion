/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programa10;

import java.util.Scanner;


public class Programa10 {

    public static void main(String[] args) {
        Scanner it = new Scanner(System.in);
        double are,per,apo;
        System.out.println("Area de un hexagono");
        System.out.print("Ingresa la medida de uno de sus lados: ");
        per= it.nextInt();
        System.out.print("Ingresa el apotemna: ");
        apo = it.nextInt();
        
        per=per*6;
        are=(per*apo)/2;
        

                                
        System.out.println("El area del hexagono es de "+are);
    }
    
}
