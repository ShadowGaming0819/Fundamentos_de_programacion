/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa3 {

    public static void main(String[] args) {
        Scanner it = new Scanner(System.in);
        double p1,p2,p3, subtotal, total, ivat;
        final double iva = 0.16;
        System.out.print("Escribe el precio 1: ");
        p1 = it.nextDouble();
                System.out.print("Escribe el precio 2: ");
        p2 = it.nextDouble();
                System.out.print("Escribe el precio 3: ");
        p3 = it.nextDouble();
        
        total = p1 + p2 + p3;
        ivat = total * iva;
        subtotal = total - ivat;
        
        System.out.println("TOTAL: "+total);
        System.out.println("IVA: "+ivat);
        System.out.println("SUBTOTAL: "+subtotal);
    }
}
