/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programa9;

import java.util.Scanner;

public class Programa9 {

    public static void main(String[] args) {
        Scanner it = new Scanner(System.in);
        double n1, n2,sum,res,mul,div;
        System.out.println("Mini calculadora");
        System.out.print("Ingresa primer numero: ");
        n1 = it.nextInt();
        System.out.print("Ingresa segundo numero: ");
        n2 = it.nextInt();
        
        sum=n1+n2;
        res=n1-2;
        mul=n1*n2;
        div=n1/n2;
                                
        System.out.println("El resultado de las operaciones fueron "+"Suma: "+sum+" Resta: "+res+" Multiplicacion: "+mul+" Division: "+div);
    }
    
}
