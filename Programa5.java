/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa5;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa5 {

    public static void main(String[] args) {
        Scanner it = new Scanner(System.in);
        int x, a , y;
        System.out.println("Programa para resolver x=y+a+3");
        
        System.out.print("Ingresa y: ");
        y = it.nextInt();
        System.out.print("Ingresa a: ");
        a = it.nextInt();
        
        x= y+a+3;
        
        System.out.println("El valor de x es: "+x);

        
    }
}
