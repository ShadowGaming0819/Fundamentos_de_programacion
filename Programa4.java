/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa4;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa4 {

    public static void main(String[] args) {
        Scanner it = new Scanner(System.in);
        int c1, c2, c3, c4, c5, c6, suma,total;

        System.out.println("Calcular el promedio de 6 calificaciones");

        System.out.print("Calificacion 1: ");
        c1 = it.nextInt();
                System.out.print("Calificacion 2: ");
        c2 = it.nextInt();
                System.out.print("Calificacion 3: ");
        c3 = it.nextInt();
                System.out.print("Calificacion 4: ");
        c4 = it.nextInt();
                System.out.print("Calificacion 5: ");
        c5 = it.nextInt();
                System.out.print("Calificacion 6: ");
        c6 = it.nextInt();
        
        suma = c1+ c2+ c3+ c4+ c5+ c6;
        total = suma / 6;
        
        System.out.println("Su calificacion es: "+total);
        
    }
}
